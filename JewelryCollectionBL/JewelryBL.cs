using MyJewelryCollectionDataServices;
using JewelryCollection;

namespace JewelryCollectionBL
{
    public class BusinessLogic
    {
        private List<Jewelry> jewelryList = new List<Jewelry>();

        public void AddJewelry(Jewelry Jewelry)
        {
            jewelryList.Add(Jewelry);
        }

        public Jewelry SearchJewelry(string brand)
        {
            Jewelry foundJewelry = null;

            foreach (Jewelry jewelry in jewelryList)
            {
                if (jewelry.brand.Equals(brand))
                {
                    foundJewelry = jewelry;
                    break;
                }
            }

            return foundJewelry;
        }

        public void RemoveJewelry(Jewelry jewelryToRemove)
        {
            jewelryList.Remove(jewelryToRemove);
        }


        public bool VerifyUserLogin(string username, string password)
        {
            DataServices dataService = new DataServices();
            var result = dataService.GetUserLogin(username, password);
            if (result.username == username && result.password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}