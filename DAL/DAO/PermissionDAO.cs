using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

namespace DAL.DAO
{
   public class PermissionDAO:EmployeeContext
    {
		public static void AddPermission(PERMISSION permission)
        {
            try
            {
                db.PERMISSIONs.InsertOnSubmit(permission);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
		public static List<PERMSSIONSTATE> GetStates()
        {
            return db.PERMSSIONSTATEs.ToList();
        }

        public static List<PermissionDetailDTO> GetPermissions()
        {
            List<PermissionDetailDTO> permissionlist = new List<PermissionDetailDTO>();
            var list = (from p in db.PERMISSIONs
                        join s in db.PERMSSIONSTATEs on p.PermissionState equals s.ID
                        join e in db.EMPLOYEEs on p.EmployeeID equals e.ID

                        select new {
                            UserNo=e.UserNo,
                            name=e.Name,
                            Surname=e.Surname,
                            StateName=s.StateName,
                            stateID=p.PermissionState,
                            startdate=p.PermissionStartDate,
                            enddate=p.PermissionEndDate,
                            employeeID=p.EmployeeID,
                            PermissionID=p.ID,
                            explanation=p.PermissionExplanation,
                            Dayamount=p.PermissionDay,
                            departmentID=e.DepartmentID,
                            positionID=e.PositionID
                        }).OrderBy(x=>x.startdate).ToList();
            foreach (var item in list)
            {
                PermissionDetailDTO dto = new PermissionDetailDTO();
                dto.UserNo = item.UserNo;
                dto.Name = item.name;
                dto.Surname = item.Surname;
                dto.EmployeeID = item.employeeID;
                dto.PermissionDayAmount = item.Dayamount;
                dto.StartDate = item.startdate;
                dto.EndDate = item.enddate;
                dto.DepartmentID = item.departmentID;
                dto.PositionID = item.positionID;
                dto.State = item.stateID;
                dto.StateName = item.StateName;
                dto.Explanation = item.explanation;
				dto.PermissionID = item.PermissionID;
                permissionlist.Add(dto);
            }
                  
            return permissionlist;
        }
		public static void UpdatePermission(PERMISSION permission)
        {
            try
            {
                PERMISSION pr = db.PERMISSIONs.First(x => x.ID == permission.ID);
                pr.PermissionStartDate = permission.PermissionStartDate;
                pr.PermissionEndDate = permission.PermissionEndDate;
                pr.PermissionExplanation = permission.PermissionExplanation;
                pr.PermissionDay = permission.PermissionDay;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
