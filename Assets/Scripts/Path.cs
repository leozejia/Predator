using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SWS;

namespace Leo
{
    public class Path : MonoBehaviour
    {
        public Transform model = null;

        [System.Serializable]
        public class PathEntity
        {
            public string name = "";
            public Transform model = null;
            public bool pathOpen = false;
            public bool effectOpen = false;
            public splineMove splineMove = null;
            public GameObject effect = null;
        }

        public List<PathEntity> pathEntities = null;
        private Dictionary<string, PathEntity> pathDic = new Dictionary<string, PathEntity>();

        private void Awake()
        {
            for (int i = 0; i < pathEntities.Count; i++)
            {
                if (!pathDic.ContainsKey(pathEntities[i].name))
                {
                    pathDic.Add(pathEntities[i].name, pathEntities[i]);
                }
                pathEntities[i].model = model.Find(pathEntities[i].name);
                pathEntities[i].splineMove = pathEntities[i].model.GetComponent<splineMove>();
                pathEntities[i].effect = pathEntities[i].model.Find("Wave_Effect").gameObject;
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            foreach (PathEntity item in pathDic.Values)
            {
                if (item.splineMove != null)
                {
                    item.splineMove.StartMove();
                    item.splineMove.Pause();
                    item.effect.SetActive(false);
                }
            }
        }

        public void SetPath(string _pathName,bool _openEffect = false)
        {
            if (!pathDic.ContainsKey(_pathName))
                return;
            else
            {
                if (_openEffect)
                {
                    pathDic[_pathName].effectOpen = !pathDic[_pathName].effectOpen;
                    //打开路径
                    pathDic[_pathName].effect.SetActive(pathDic[_pathName].effectOpen);
                }
                else
                {
                    pathDic[_pathName].pathOpen = !pathDic[_pathName].pathOpen;
                    if (pathDic[_pathName].pathOpen)
                    {
                        //打开路径
                        if (pathDic[_pathName].splineMove != null)
                        {
                            pathDic[_pathName].splineMove.Resume();
                        }
                    }
                    else
                    {
                        //打开路径
                        if (pathDic[_pathName].splineMove != null)
                        {
                            pathDic[_pathName].splineMove.Pause();
                        }
                    }
                }
            }
        }
    }

}