using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;

namespace AutoUpdateRef
{
    public class UpdateRefUtil
    {
        [CommandMethod("arefe")]
        public void AttachingExternalReference()
        {
            RefUpdateForm layerForm = new RefUpdateForm();
            layerForm.Show();
        }
        public void AttachingExternalReference(string dwgPath)
        {
            Document doc = Application.DocumentManager.Open(dwgPath);
            Database db = doc.Database;
            Editor edt = doc.Editor;

            doc.LockDocument();
            try
            {
                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    ObjectId acXrefId = db.AttachXref(dwgPath, "Exterior Elevations");

                    // If a valid reference is created then continue
                    if (!acXrefId.IsNull)
                    {
                        // Attach the DWG reference to the current space
                        Point3d insPt = new Point3d(1, 1, 0);
                        using (BlockReference acBlkRef = new BlockReference(insPt, acXrefId))
                        {
                            BlockTableRecord acBlkTblRec;
                            acBlkTblRec = trans.GetObject(db.CurrentSpaceId, OpenMode.ForWrite) as BlockTableRecord;

                            acBlkTblRec.AppendEntity(acBlkRef);
                            trans.AddNewlyCreatedDBObject(acBlkRef, true);
                        }

                        Application.ShowAlertDialog("The external reference is attached.");

                        using (ObjectIdCollection acXrefIdCol = new ObjectIdCollection())
                        {
                            acXrefIdCol.Add(acXrefId);

                            db.ReloadXrefs(acXrefIdCol);
                        }

                        Application.ShowAlertDialog("The external reference is reloaded.");
                    }
                    trans.Commit();
                }
                
                doc.CloseAndDiscard();
            }
            catch (Autodesk.AutoCAD.Runtime.Exception ex)
            {
                edt.WriteMessage("Error encountered: " + ex.Message);
            }
        }
    }
}
