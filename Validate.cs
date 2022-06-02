//summary: Validates movements, input, and anything else that needs validation

namespace Chess
{
   class Validate
   {
      //Attributes

      //Constructor
      public Validate()
      {
         
      }
      
      
      /*
      summary: Checks if piece selection is valid 
      param: (string location) the location of the piece || (string player) which player is making the move
      return: (bool isValid) if the piece selection is valid or not
      */
      public bool CheckPieceSelection(string location, string player)
      {
         bool isValid;
         if (player == "white")
         {
            isValid = ValidateWhiteSelection(location);
         }
         else
         {
            isValid = ValidateBlackSelection(location);
         }

         return isValid;
      }
      
      
      /*
      summary: Validate the piece selection of player white 
      param: (string location) the location of the piece selected
      return: (bool isValid) if the piece selection is valid or not
      */
      private bool ValidateWhiteSelection(string location)
      {
         
      }
      
      
      /*
      summary: Validate the piece selection of player black 
      param:(string location) the location of the piece selected
      return:(bool isValid) if the piece selection is valid or not
      */
      private bool ValidateBlackSelection(string location)
      {
         
      }
      
   }
}
