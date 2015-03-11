﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace MiniWeChat
{
    public class ContactsPanel : MonoBehaviour
    {
        private const int CONTACT_FRAME_HEIGHT = 200;

        public VerticalLayoutGroup _contactsGrid;

        public void Start()
        {
            int chatNum = 10;
            _contactsGrid.GetComponent<RectTransform>().sizeDelta = new Vector2(1080, CONTACT_FRAME_HEIGHT * chatNum);
            for (int i = 0; i < chatNum; i++)
            {
                GameObject go = UIManager.GetInstance().AddChild(_contactsGrid.gameObject, EUIType.ContactFrame);
            }
        }

        public void Show(bool isShow)
        {
            gameObject.SetActive(isShow);
        }
    }
}
