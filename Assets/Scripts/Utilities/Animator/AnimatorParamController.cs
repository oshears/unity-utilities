using System;
using System.Collections.Generic;
using UnityEngine;

namespace OSGames.Utilities.Animations {

    using UnityEngine;
    
    [RequireComponent(typeof(Animator))]
    public class AnimatorParamController : MonoBehaviour {
        
        Animator m_Animator;
        void Awake(){
            m_Animator = GetComponent<Animator>();
        }

        public void SetBool(string boolName){
            m_Animator.SetBool(boolName,true);
        }

        public void ClearBool(string boolName){
            m_Animator.SetBool(boolName,false);
        }
    }

}