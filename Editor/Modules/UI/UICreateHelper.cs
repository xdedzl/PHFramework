﻿using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

/// <summary>
/// 用于创建一些自定义UI组件
/// </summary>
namespace PHFramework.UI
{
    public class UICreateHelper
    {
        private static DefaultControls.Resources s_StandardResources;

        private const string kUILayerName = "UI";

        private const string kStandardSpritePath = "UI/Skin/UISprite.psd";
        private const string kBackgroundSpritePath = "UI/Skin/Background.psd";
        private const string kInputFieldBackgroundPath = "UI/Skin/InputFieldBackground.psd";
        private const string kKnobPath = "UI/Skin/Knob.psd";
        private const string kCheckmarkPath = "UI/Skin/Checkmark.psd";
        private const string kDropdownArrowPath = "UI/Skin/DropdownArrow.psd";
        private const string kMaskPath = "UI/Skin/UIMask.psd";

        [MenuItem("GameObject/UI/Tree")]
        public static void CreateTree()
        {
            GameObject parent = Selection.activeGameObject;

            RectTransform tree = new GameObject("Tree").AddComponent<RectTransform>();
            tree.SetParent(parent.transform);
            tree.localPosition = Vector3.zero;
            tree.gameObject.AddComponent<PHFramework.UI.Tree>();
            tree.sizeDelta = new Vector2(180, 30);

            // 设置模板
            RectTransform itemTemplate = new GameObject("NodeTemplate").AddComponent<RectTransform>();
            itemTemplate.SetParent(tree);
            itemTemplate.pivot = new Vector2(0, 1);
            itemTemplate.anchorMin = new Vector2(0, 1);
            itemTemplate.anchorMax = new Vector2(0, 1);
            itemTemplate.anchoredPosition = new Vector2(0, 0);
            itemTemplate.sizeDelta = new Vector2(180, 30);

            RectTransform body = DefaultControls.CreateButton(GetStandardResources()).GetComponent<RectTransform>();
            body.name = "Body";
            body.SetParent(itemTemplate);
            body.anchoredPosition = new Vector2(10, 0);
            body.sizeDelta = new Vector2(160, 30);
            Object.DestroyImmediate(body.GetComponent<Button>());
            body.gameObject.AddComponent<Toggle>();
            body.GetComponentInChildren<Text>().text = "Root";

            //RectTransform toggle = DefaultControls.CreateToggle(GetStandardResources()).GetComponent<RectTransform>();
            //toggle.SetParent(itemTemplate);
            //Object.DestroyImmediate(toggle.Find("Label").gameObject);
            //toggle.anchoredPosition = new Vector2(-80, 0);
            //toggle.sizeDelta = new Vector2(20, 20);

            RectTransform toggle = DefaultControls.CreateImage(GetStandardResources()).GetComponent<RectTransform>();
            toggle.name = "Toggle";
            toggle.SetParent(itemTemplate);
            toggle.anchoredPosition = new Vector2(-80, 0);
            toggle.sizeDelta = new Vector2(20, 20);
            toggle.gameObject.AddComponent<Toggle>();

            RectTransform child = new GameObject("Child").AddComponent<RectTransform>();
            child.SetParent(itemTemplate);
            child.pivot = new Vector2(0, 1);
            child.anchorMin = new Vector2(0, 1);
            child.anchorMax = new Vector2(0, 1);
            child.sizeDelta = Vector2.zero;
            child.anchoredPosition = new Vector2(20, -30);


            // 设置树的跟结点位置
            RectTransform treeRoot = new GameObject("Root").AddComponent<RectTransform>();
            treeRoot.SetParent(tree);
            treeRoot.pivot = new Vector2(0, 1);
            treeRoot.anchorMin = new Vector2(0, 1);
            treeRoot.anchorMax = new Vector2(0, 1);
            treeRoot.anchoredPosition = new Vector2(0, 0);
            treeRoot.sizeDelta = new Vector2(0, 0);
        }

        [MenuItem("GameObject/UI/SliderMixInput")]
        public static void CreateSliderMixInput()
        {
            GameObject parent = Selection.activeGameObject;

            RectTransform mix = new GameObject("SliderMixInput").AddComponent<RectTransform>();
            mix.SetParent(parent.transform);
            mix.anchoredPosition = Vector2.zero;
            mix.sizeDelta = new Vector2(210, 25);

            // 设置Text
            RectTransform text = DefaultControls.CreateText(GetStandardResources()).GetComponent<RectTransform>();
            text.SetParent(mix);
            text.name = "Name";
            text.anchorMin = new Vector2(0, 0.5f);
            text.anchorMax = new Vector2(0, 0.5f);
            text.sizeDelta = new Vector2(50, 25);
            text.pivot = new Vector2(0, 0.5f);
            text.anchoredPosition = new Vector2(25, 0);
            text.GetComponent<Text>().text = "Name";
            text.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;

            // 设置滑动条
            RectTransform slider = DefaultControls.CreateSlider(GetStandardResources()).GetComponent<RectTransform>();
            slider.SetParent(mix);
            slider.sizeDelta = new Vector2(80, 20);
            slider.anchoredPosition = new Vector2(-15, 0);

            // 设置输入框
            RectTransform input = DefaultControls.CreateInputField(GetStandardResources()).GetComponent<RectTransform>();
            input.SetParent(mix);
            input.anchorMin = new Vector2(1, 0.5f);
            input.anchorMax = new Vector2(1, 0.5f);
            input.sizeDelta = new Vector2(80, 20);
            input.anchoredPosition = new Vector2(-40, 0);

            mix.gameObject.AddComponent<PHFramework.UI.SliderMixInput>();
        }

        [MenuItem("GameObject/UI/DividingRule")]
        public static void CreateDividingRule()
        {
            GameObject parent = Selection.activeGameObject;
            parent = parent ?? Object.FindFirstObjectByType<Canvas>().gameObject;
            RectTransform rule = new GameObject("DividingRule").AddComponent<RectTransform>();
            rule.SetParent(parent.transform);
            rule.anchoredPosition = Vector2.zero;
            rule.sizeDelta = new Vector2(1000, 100);

            RectTransform textTmp = DefaultControls.CreateText(GetStandardResources()).GetComponent<RectTransform>();
            textTmp.SetParent(rule);
            textTmp.name = "textTmp";
            textTmp.gameObject.AddComponent<ContentSizeFitter>().horizontalFit = ContentSizeFitter.FitMode.PreferredSize;

            RectTransform timeUnitText = DefaultControls.CreateText(GetStandardResources()).GetComponent<RectTransform>();
            timeUnitText.SetParent(rule);
            timeUnitText.name = "timeUnitText";
            timeUnitText.gameObject.AddComponent<ContentSizeFitter>().horizontalFit = ContentSizeFitter.FitMode.PreferredSize;

            rule.gameObject.AddComponent<PHFramework.UI.DividingRule>();
        }

        [MenuItem("GameObject/UI/ColorPicker")]
        public static void CreateColorPicker()
        {
            XDefaultControls.CreateColorPicker(GetStandardResources());
        }


        [MenuItem("GameObject/UI/Knob")]
        public static void CreateKnob()
        {
            XDefaultControls.CreateKnob(GetStandardResources());
        }

        private static DefaultControls.Resources GetStandardResources()
        {
            if (s_StandardResources.standard == null)
            {
                s_StandardResources.standard = AssetDatabase.GetBuiltinExtraResource<Sprite>(kStandardSpritePath);
                s_StandardResources.background = AssetDatabase.GetBuiltinExtraResource<Sprite>(kBackgroundSpritePath);
                s_StandardResources.inputField = AssetDatabase.GetBuiltinExtraResource<Sprite>(kInputFieldBackgroundPath);
                s_StandardResources.knob = AssetDatabase.GetBuiltinExtraResource<Sprite>(kKnobPath);
                s_StandardResources.checkmark = AssetDatabase.GetBuiltinExtraResource<Sprite>(kCheckmarkPath);
                s_StandardResources.dropdown = AssetDatabase.GetBuiltinExtraResource<Sprite>(kDropdownArrowPath);
                s_StandardResources.mask = AssetDatabase.GetBuiltinExtraResource<Sprite>(kMaskPath);
            }
            return s_StandardResources;
        }
    }


    public static class XDefaultControls
    {
        public static GameObject CreateColorPicker(DefaultControls.Resources resources)
        {
            GameObject parent = Selection.activeGameObject;

            ColorPicker colorPicker = DefaultControls.CreateRawImage(resources).AddComponent<ColorPicker>();
            colorPicker.gameObject.name = "ColorPicker";
            colorPicker.transform.SetParent(parent.transform, false);
            colorPicker.transform.localPosition = Vector3.zero;
            Material colorPickerMaterial = new Material(Shader.Find("UI/ColorPicker/ColorPicker"));
            colorPicker.GetComponent<RawImage>().material = colorPickerMaterial;

            GameObject colorKnob = CreateKnob(resources);
            colorKnob.transform.SetParent(colorPicker.transform, false);
            colorKnob.transform.RectTransform().anchorMax = Vector2.zero;
            colorKnob.transform.RectTransform().anchorMin = Vector2.zero;
            colorKnob.transform.RectTransform().anchoredPosition = Vector2.zero;

            GameObject huePicker = DefaultControls.CreateRawImage(resources);
            huePicker.name = "HuePicker";
            huePicker.transform.SetParent(colorPicker.transform, false);
            huePicker.transform.RectTransform().sizeDelta = huePicker.transform.RectTransform().sizeDelta.WithY(10);
            huePicker.transform.RectTransform().anchorMax = new Vector2(0.5f, 0f);
            huePicker.transform.RectTransform().anchorMin = new Vector2(0.5f, 0f);
            huePicker.transform.RectTransform().anchoredPosition = Vector2.zero;
            huePicker.transform.RectTransform().pivot = new Vector2(0.5f, 1f);
            Material huePickerMaterial = new Material(Shader.Find("UI/ColorPicker/HuePicker"));
            huePicker.GetComponent<RawImage>().material = huePickerMaterial;

            GameObject hueKnob = CreateKnob(resources);
            hueKnob.transform.SetParent(huePicker.transform, false);
            hueKnob.transform.RectTransform().anchorMax = new Vector2(0f, 0.5f);
            hueKnob.transform.RectTransform().anchorMin = new Vector2(0f, 0.5f);
            hueKnob.transform.RectTransform().anchoredPosition = Vector2.zero;
            hueKnob.GetComponent<Knob>().vertical = false;

            colorPicker.knob = colorKnob.GetComponent<Knob>();
            colorPicker.hueKnob = hueKnob.GetComponent<Knob>();

            return colorPicker.gameObject;
        }


        public static GameObject CreateKnob(DefaultControls.Resources resources)
        {
            Transform parent = Selection.activeGameObject.transform;

            GameObject knob = DefaultControls.CreateImage(resources);
            knob.name = "Knob";
            Image knobImg = knob.GetComponent<Image>();
            knobImg.sprite = resources.knob;
            knobImg.rectTransform.sizeDelta = new Vector2(20, 20);
            knob.transform.SetParent(parent);
            knob.transform.localPosition = Vector3.zero;
            knob.AddComponent<Knob>();

            GameObject foreground = DefaultControls.CreateImage(resources);
            foreground.name = "Foreground";
            Image foregroundImg = foreground.GetComponent<Image>();
            foregroundImg.sprite = resources.knob;
            foregroundImg.rectTransform.sizeDelta = new Vector2(10, 10);
            foreground.transform.SetParent(knob.transform);
            foreground.transform.localPosition = Vector3.zero;

            return knob;
        }
    }
}
