using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    //  Principio SRP y Creator
    public class EquipmentCatalog
    {
        public static List<Equipment> equipmentCatalog = new List<Equipment>();
        public static Equipment AddEquipmentToCatalog(string description, double hourlyCost)
        {
            Equipment equipment= new Equipment(description, hourlyCost);
            equipmentCatalog.Add(equipment);
            return equipment;
        }
        public static Equipment EquipmentAt(int index)
        {
            return equipmentCatalog[index] as Equipment;
        }
        public static Equipment GetEquipment(string description)
        {
            var query = from Equipment equipment in equipmentCatalog where equipment.Description == description select equipment;
            return query.FirstOrDefault();
        }
    }
}