using System;
using System.Collections.Generic;
using System.Reflection;
using CVTest8.Enums;
using CVTest8.Extensions;
using CVTest8.Model;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CVTest8.Markups
{
    public class OnScreenSize : IMarkupExtension
    {
        private static List<ScreenInfo> _screenSizes = new List<ScreenInfo>
        {

            { new ScreenInfo(480,800, ScreenSizes.Nexus1)}, // Android Device
            { new ScreenInfo(640,1136, ScreenSizes.iPod)},  // iOS Device
            { new ScreenInfo(720,1280, ScreenSizes.NexusR)}, // Android Device
            { new ScreenInfo(750,1334, ScreenSizes.iPhoneSE)}, // iOS Device
            { new ScreenInfo(800,1280, ScreenSizes.Nexus7R)}, // Android Device
            { new ScreenInfo(828,1792, ScreenSizes.iPhoneXR)}, // iOS Device
            { new ScreenInfo(1080,1920, ScreenSizes.Pixel2R)}, // Android Device
            { new ScreenInfo(1080,2160, ScreenSizes.Pixel3R)}, // Android Device
            { new ScreenInfo(1080,2280, ScreenSizes.GalaxyS8)}, // Android Device
            { new ScreenInfo(1125,2436, ScreenSizes.iPhoneX)}, // iOS Device
            { new ScreenInfo(1170,2532, ScreenSizes.iPhone13)}, // iOS Device
            { new ScreenInfo(1242,2208, ScreenSizes.iPhone7p)}, // iOS Device
            { new ScreenInfo(1242,2688, ScreenSizes.iPhone11pm)}, // iOS Device
            { new ScreenInfo(1284,2778, ScreenSizes.iPhone13pm)}, // iOS Device
            { new ScreenInfo(1440,2560, ScreenSizes.Nexus6P)}, // Android Device
            { new ScreenInfo(1440,2960, ScreenSizes.Pixel3XL)}, // Android Device
            { new ScreenInfo(1488,2266, ScreenSizes.iPadMini)}, // iOS Device
            { new ScreenInfo(1536,2048, ScreenSizes.iPad9p7)}, // iOS Device
            { new ScreenInfo(1620,2160, ScreenSizes.iPad)}, // iOS Device
            { new ScreenInfo(1640,2360, ScreenSizes.iPadAir)}, // iOS Device
            { new ScreenInfo(1668,2388, ScreenSizes.iPad11)}, // iOS Device
            { new ScreenInfo(1800,2560, ScreenSizes.PixelC)}, // Android Device
            { new ScreenInfo(2048,2732, ScreenSizes.iPad12p9)}, // iOS Device

            
        };



        private Dictionary<ScreenSizes, object> _values = new Dictionary<ScreenSizes, object>()
        {
            { ScreenSizes.Nexus1, null}, // Android Device
            { ScreenSizes.iPod, null}, // iOS Device
            { ScreenSizes.NexusR, null}, // Android Device
            { ScreenSizes.iPhoneSE, null}, // iOS Device
            { ScreenSizes.iPhoneXR, null}, // iOS Device
            { ScreenSizes.Pixel2R, null}, // Android Device
            { ScreenSizes.Pixel3R, null}, // Android Device
            { ScreenSizes.GalaxyS8, null}, // Android Device
            { ScreenSizes.iPhoneX,  null}, // iOS Device
            { ScreenSizes.iPhone13,  null}, // iOS Device
            { ScreenSizes.iPhone7p,  null}, // iOS Device
            { ScreenSizes.iPhone11pm,  null}, // iOS Device
            { ScreenSizes.iPhone13pm,  null}, // iOS Device
            { ScreenSizes.Nexus6P, null}, // Android Device
            { ScreenSizes.Pixel3XL, null}, // Android Device
            { ScreenSizes.iPadMini,  null}, // iOS Device
            { ScreenSizes.iPad9p7,  null}, // iOS Device
            { ScreenSizes.iPad,  null}, // iOS Device
            { ScreenSizes.iPadAir,  null}, // iOS Device
            { ScreenSizes.iPad11,  null}, // iOS Device
            { ScreenSizes.PixelC, null}, // Android Device
            { ScreenSizes.iPad12p9,  null}, // iOS Device
    
        };



        public OnScreenSize()
        {
        }


        private static ScreenSizes? deviceScreenSize;


        public object DefaultSize { get; set; }


        public object Nexus1
        {
            get
            {

                return _values[ScreenSizes.Nexus1];
            }
            set
            {
                _values[ScreenSizes.Nexus1] = value;
            }
        }

        public object iPod
        {
            get
            {

                return _values[ScreenSizes.iPod];
            }
            set
            {
                _values[ScreenSizes.iPod] = value;
            }
        }

        public object NexusR
        {
            get
            {

                return _values[ScreenSizes.NexusR];
            }
            set
            {
                _values[ScreenSizes.NexusR] = value;
            }
        }

        public object iPhoneSE
        {
            get
            {

                return _values[ScreenSizes.iPhoneSE];
            }
            set
            {
                _values[ScreenSizes.iPhoneSE] = value;
            }
        }

        public object Nexus7R
        {
            get
            {

                return _values[ScreenSizes.Nexus7R];
            }
            set
            {
                _values[ScreenSizes.Nexus7R] = value;
            }
        }


        public object iPhoneXR
        {
            get
            {

                return _values[ScreenSizes.iPhoneXR];
            }
            set
            {
                _values[ScreenSizes.iPhoneXR] = value;
            }
        }

        public object Pixel2R
        {
            get
            {

                return _values[ScreenSizes.Pixel2R];
            }
            set
            {
                _values[ScreenSizes.Pixel2R] = value;
            }
        }

        public object Pixel3R
        {
            get
            {

                return _values[ScreenSizes.Pixel3R];
            }
            set
            {
                _values[ScreenSizes.Pixel3R] = value;
            }
        }

        public object GalaxyS8
        {
            get
            {

                return _values[ScreenSizes.GalaxyS8];
            }
            set
            {
                _values[ScreenSizes.GalaxyS8] = value;
            }
        }

        public object iPhoneX
        {
            get
            {

                return _values[ScreenSizes.iPhoneX];
            }
            set
            {
                _values[ScreenSizes.iPhoneX] = value;
            }
        }

        public object iPhone13
        {
            get
            {

                return _values[ScreenSizes.iPhone13];
            }
            set
            {
                _values[ScreenSizes.iPhone13] = value;
            }
        }

        public object iPhone7p
        {
            get
            {

                return _values[ScreenSizes.iPhone7p];
            }
            set
            {
                _values[ScreenSizes.iPhone7p] = value;
            }
        }

        public object iPhone11pm
        {
            get
            {

                return _values[ScreenSizes.iPhone11pm];
            }
            set
            {
                _values[ScreenSizes.iPhone11pm] = value;
            }
        }

        public object iPhone13pm
        {
            get
            {

                return _values[ScreenSizes.iPhone13pm];
            }
            set
            {
                _values[ScreenSizes.iPhone13pm] = value;
            }
        }
        public object Nexus6P
        {
            get
            {

                return _values[ScreenSizes.Nexus6P];
            }
            set
            {
                _values[ScreenSizes.Nexus6P] = value;
            }
        }

        public object Pixel3XL
        {
            get
            {

                return _values[ScreenSizes.Pixel3XL];
            }
            set
            {
                _values[ScreenSizes.Pixel3XL] = value;
            }
        }

        public object iPadMini
        {
            get
            {

                return _values[ScreenSizes.iPadMini];
            }
            set
            {
                _values[ScreenSizes.iPadMini] = value;
            }
        }

        public object iPad9p7
        {
            get
            {

                return _values[ScreenSizes.iPad9p7];
            }
            set
            {
                _values[ScreenSizes.iPad9p7] = value;
            }
        }

        public object iPad
        {
            get
            {

                return _values[ScreenSizes.iPad];
            }
            set
            {
                _values[ScreenSizes.iPad] = value;
            }
        }

        public object iPadAir
        {
            get
            {

                return _values[ScreenSizes.iPadAir];
            }
            set
            {
                _values[ScreenSizes.iPadAir] = value;
            }
        }

        public object iPad11
        {
            get
            {

                return _values[ScreenSizes.iPad11];
            }
            set
            {
                _values[ScreenSizes.iPad11] = value;
            }
        }

        public object PixelC
        {
            get
            {

                return _values[ScreenSizes.PixelC];
            }
            set
            {
                _values[ScreenSizes.PixelC] = value;
            }
        }

        public object iPad12p9
        {
            get
            {

                return _values[ScreenSizes.iPad12p9];
            }
            set
            {
                _values[ScreenSizes.iPad12p9] = value;
            }
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var valueProvider = serviceProvider?.GetService<IProvideValueTarget>() ?? throw new ArgumentException();

            BindableProperty bp;
            PropertyInfo pi = null;
            Type propertyType = null;

            if (valueProvider.TargetObject is Setter setter)
            {
                bp = setter.Property;
            }
            else
            {
                bp = valueProvider.TargetProperty as BindableProperty;
                pi = valueProvider.TargetProperty as PropertyInfo;
            }

            propertyType = bp?.ReturnType ?? pi?.PropertyType ?? throw new InvalidOperationException("Unable to determine property value.");

            var value = GetValue(serviceProvider);

            return value.ConvertTo(propertyType, bp);
        }


        private object GetValue(IServiceProvider serviceProvider)
        {
            var screenSize = GetScreenSize();
            if (screenSize != ScreenSizes.NotSet)
            {
                if (_values[screenSize] != null)
                {
                    return _values[screenSize];
                }
            }

            if (DefaultSize == null)
            {
                throw new XamlParseException("OnScreenExtension requires a DefaultSize set.");
            }
            else
            {
                return DefaultSize;
            }
        }


        private ScreenSizes GetScreenSize()
        {
            if (TryGetScreenSize(out var screenSize))
            {
                return screenSize;
            }

            return ScreenSizes.NotSet;
        }


        private static bool TryGetScreenSize(out ScreenSizes screenSize)
        {
            if (deviceScreenSize != null)
            {
                if (deviceScreenSize.Value == ScreenSizes.NotSet)
                {
                    screenSize = deviceScreenSize.Value;
                    return false;
                }
                else
                {
                    screenSize = deviceScreenSize.Value;
                    return true;
                }
            }


            var device = DeviceDisplay.MainDisplayInfo;

            var deviceWidth = device.Width;
            var deviceHeight = device.Height;


            if (Xamarin.Essentials.DeviceInfo.Idiom == Xamarin.Essentials.DeviceIdiom.Tablet)
            {
                deviceWidth = Math.Min(device.Width, device.Height);
                deviceHeight = Math.Max(device.Width, device.Height);
            }


            foreach (var sizeInfo in _screenSizes)
            {
                if (deviceWidth <= sizeInfo.Width &&
                    deviceHeight <= sizeInfo.Height)
                {
                    deviceScreenSize = sizeInfo.ScreenSize;
                    screenSize = deviceScreenSize.Value;
                    return true;
                }
            }

            deviceScreenSize = ScreenSizes.NotSet;
            screenSize = deviceScreenSize.Value;
            return false;
        }
    }
}
