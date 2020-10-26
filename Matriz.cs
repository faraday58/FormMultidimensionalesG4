
namespace FormMultidimensionalesG4
{
    class Matriz
    {
        #region Atributos
        private int n;
        private int m;
        #endregion
        #region Propiedades
        public int N { 
            get => n;
            set
            {
                if(  value < 2  )
                {
                    n = 2;
                }
                else
                {
                    n = value;
                }
                
            }
        }
        public int M { 
            get => m;
            set
            {
                if( value < 2)
                {
                    m = 2;
                }
                else
                {
                    m = value;
                }
                
            }
        }
        #endregion
    }
}
