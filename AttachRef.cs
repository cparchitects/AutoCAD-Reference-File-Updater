using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using System.IO;

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
            // Get the current database and start a transaction
            Document doc = Application.DocumentManager.Open(dwgPath);
            Database acCurDb;
            Editor edt = doc.Editor;
            //doc.LockDocument();
          
            using (DocumentLock acLckDoc = doc.LockDocument())
            {
                acCurDb = Application.DocumentManager.MdiActiveDocument.Database;

                acCurDb.ResolveXrefs(true, false);
                using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())
                {
                    XrefGraph xg = acCurDb.GetHostDwgXrefGraph(true);

                    int xrefcount = xg.NumNodes;
                    edt.WriteMessage("\nNumber of references: " + xrefcount.ToString());// print the count of reference files attached

                    for (int j = 0; j < xrefcount; j++)
                    {
                        XrefGraphNode xrNode = xg.GetXrefNode(j);
                        string nodeName = xrNode.Name;
                        
                        if (nodeName.Contains(filter))// need to add input from user here......
                        {
                            BlockTableRecord btr = (BlockTableRecord)acTrans.GetObject(xrNode.BlockTableRecordId, OpenMode.ForWrite);

                            acCurDb.XrefEditEnabled = true;
                            btr.Name = refName;
                            btr.PathName = refPath;
                            break;
                        }
                        //// this section not needed just left in for future reference
                        //if (xrNode.XrefStatus == XrefStatus.FileNotFound)
                        //{
                        //    ObjectId detachid = xrNode.BlockTableRecordId;                        
                        //    acCurDb.DetachXref(detachid);
                        //    edt.WriteMessage("\nDetached successfully");
                        //    break;
                        //}
                    }
                    // Save the new objects to the database
                    acTrans.Commit();
                }
            }


            // Save the active drawing
            acCurDb.SaveAs(dwgPath, DwgVersion.Current);
            doc.CloseAndDiscard(); ;
        }
    }
}
