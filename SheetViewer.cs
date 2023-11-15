using System.Reflection;
namespace RPG_Dashboard
{
    internal static class SheetViewer
    {
        public static void PrintCharacter(object character)
        {   

            var type = character.GetType();
            Console.WriteLine(type.FullName);

            var properties = type.GetProperties();
            if (properties != null)
            {
                Console.WriteLine("-----------------" +
                                  " Character Stats " +
                                  "-----------------");
                foreach (var property in properties)
                {
                    Console.WriteLine(property.Name +
                                      ": " +
                                      property.GetValue(character));
                }
            }

            var possibleActions = type.GetMethods().Where(m => !m.IsSpecialName);
            if (possibleActions != null)
            {
                Console.WriteLine("-----------------" +
                                  "Available actions" +
                                  "-----------------");
                foreach (var possibleAction in possibleActions)
                {
                    Console.WriteLine(possibleAction.Name);
                }
            }
        }

    }
}
