using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System.Windows.Forms;

namespace AutoUpdateRef
{
    public class AttachRef
    {        
        [CommandMethod("CPUR")]
        public void AttachingExternalReference()
        {
            RefUpdateForm layerForm = new RefUpdateForm();
            layerForm.Show();
        }

        public void AttachingRef(string dwgPath, string refName, string refPath, string filter)
        {
            try
            {
                using (Database db = new Database(false, true))
                {
                    db.ReadDwgFile(dwgPath, FileOpenMode.OpenForReadAndAllShare, false, null);
                    using (Transaction tr = db.TransactionManager.StartTransaction())
                    {
                        XrefGraph xg = db.GetHostDwgXrefGraph(true);

                        int xrefcount = xg.NumNodes;
                        //edt.WriteMessage("\nNumber of references: " + xrefcount.ToString());// print the count of reference files attached

                        for (int j = 0; j < xrefcount; j++)
                        {
                            XrefGraphNode xrNode = xg.GetXrefNode(j);
                            string nodeName = xrNode.Name;

                            if (nodeName.Contains(filter))// need to add input from user here......
                            {
                                BlockTableRecord btr = (BlockTableRecord)tr.GetObject(xrNode.BlockTableRecordId, OpenMode.ForWrite);

                                db.XrefEditEnabled = true;
                                btr.Name = refName;
                                btr.PathName = refPath;
                                break;
                            }
                        }
                        tr.Commit();
                    }
                    db.SaveAs(dwgPath, DwgVersion.Current);
                }
            }
            catch (System.Exception ex)
            {
                string error = ex.Message;
                return;
            }            
        }
    }
}
