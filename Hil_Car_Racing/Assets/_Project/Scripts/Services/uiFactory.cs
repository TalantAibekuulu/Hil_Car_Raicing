
using Game.UI;
using UnityEngine;
namespace Game
{
    public class UIFactory : MonoBehaviour
    {
        [SerializeField] private UIBase[] _alUIs;

        private void Start()
        {
            GetUI<MainMenu_UI>();
        }

        public UIBase GetUI<_SomeUI>()
        {
           UIBase result = null;
            foreach (UIBase ui in _alUIs) 
            {
                if(ui is _SomeUI ==true)
                {
                    result =Instantiate(ui) ;
                }
            }



            return result;
        }
    }

}

