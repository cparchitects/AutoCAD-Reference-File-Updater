using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System.Windows.Forms;
using System;
using System.Linq;

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
        public void GetTitleProjectNameNumber(string titleBlockDwgPath)// this is to get the text project name and number from the titleblock dwg for tracking
        {
            try
            {
                using (Database titleDB = new Database(false, true))
                {
                    titleDB.ReadDwgFile(titleBlockDwgPath, FileOpenMode.OpenForReadAndAllShare, false, null);
                    using (Transaction tr = titleDB.TransactionManager.StartTransaction())
                    {
                        var model = (BlockTableRecord)tr.GetObject(SymbolUtilityServices.GetBlockModelSpaceId(titleDB), OpenMode.ForRead);
                        
                        foreach (ObjectId id in model)
                        {
                            if (id.ObjectClass.DxfName == "TEXT")
                            {
                                var textProjectNumber = (DBText)tr.GetObject(id, OpenMode.ForRead);                                
                                int projectNumberx = Convert.ToInt32(textProjectNumber.Position.X * 1000);
                                int projectNumbery = Convert.ToInt32(textProjectNumber.Position.Y * 1000);
                                if (projectNumberx >= 40630 && projectNumberx <= 40650 && projectNumbery >= 1370 && projectNumbery <= 1385)
                                {
                                    Globals.projectNumber = textProjectNumber.TextString;
                                }
                                var textProjectName = (DBText)tr.GetObject(id, OpenMode.ForRead);
                                int projectNameX = Convert.ToInt32((textProjectName.Position.X) * 1000);
                                int projectNameY = Convert.ToInt32((textProjectName.Position.Y) * 1000);
                                if (projectNameX >= 39500 && projectNameX <= 39509 && projectNameY >= 3450 && projectNameY <= 3460)
                                {
                                    Globals.projectName = textProjectName.TextString;
                                }
                            }

                        }
                        tr.Commit();
                    }
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
