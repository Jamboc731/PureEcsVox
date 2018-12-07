// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat4x4
    {
        [Test]
        public void float4x4_operator_equal_wide_wide()
        {
            float4x4 a0 = float4x4(492.1576f, -495.206329f, 227.457642f, -147.374054f, -222.682f, 64.09375f, -23.8904114f, -16.8197327f, 163.232117f, -165.271f, 470.8777f, -423.942566f, 109.6344f, 462.6903f, -335.38147f, 357.2345f);
            float4x4 b0 = float4x4(192.568787f, -235.611023f, -254.043121f, -412.624725f, 471.9048f, -6.47277832f, -339.102356f, 488.187561f, -379.5966f, -308.417f, -82.333374f, -102.921082f, 226.515747f, -356.9013f, -362.912781f, -427.898438f);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x4 a1 = float4x4(1.54559326f, -347.388245f, -114.472168f, 435.848633f, 194.2381f, 138.765564f, -467.349152f, 370.43335f, 476.708252f, 320.552673f, -498.59198f, 92.41693f, 104.511353f, 166.754578f, -204.733429f, 434.756775f);
            float4x4 b1 = float4x4(466.650146f, -102.799042f, -43.355957f, 85.0456543f, -91.1270447f, 422.192078f, -477.4313f, 1.87701416f, 312.580078f, 254.599365f, 352.72583f, 62.4909668f, 119.714783f, -511.058075f, -302.472717f, -371.769226f);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x4 a2 = float4x4(-397.329651f, 503.981628f, -503.7141f, 90.65973f, -303.445251f, 9.34491f, 290.901062f, -147.57193f, 368.082336f, -321.6096f, -171.465424f, -441.306458f, -137.766815f, 304.689575f, 301.889465f, -222.220917f);
            float4x4 b2 = float4x4(-20.007843f, 21.4594727f, -426.0207f, -305.411926f, 261.68335f, 50.00476f, -334.134644f, 75.0656738f, -51.186676f, -135.961548f, -409.364868f, 160.819763f, 102.120789f, 277.813049f, 434.906738f, -15.2891846f);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x4 a3 = float4x4(-13.88382f, 307.521729f, -469.412933f, -6.40887451f, -290.079651f, 46.0445557f, -168.61908f, 283.5899f, -244.713287f, -367.140442f, -492.863129f, 311.696167f, -90.7013855f, -352.773743f, -218.710266f, -95.30136f);
            float4x4 b3 = float4x4(-1.46521f, 64.65869f, -163.0261f, 390.728943f, 113.9646f, -248.2753f, -469.587769f, -73.35397f, -420.311066f, 358.453247f, 58.7183228f, -499.964783f, -168.8381f, -93.83493f, 324.84668f, -226.35199f);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4x4_operator_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(-303.230072f, 451.5263f, -253.655884f, -105.203644f, -500.6911f, -426.192474f, 159.8761f, -59.55838f, -57.4773865f, -182.049744f, 406.513733f, 370.886f, -172.035309f, 455.400024f, -11.3389893f, 363.938232f);
            float b0 = (123.544556f);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x4 a1 = float4x4(-27.1505737f, -290.359039f, 180.196838f, -374.128326f, -439.358948f, -126.546082f, -197.26178f, -227.159332f, -479.8992f, -439.777679f, -495.237335f, -224.517059f, -422.833221f, -450.196259f, -20.10672f, 297.38f);
            float b1 = (-325.976074f);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x4 a2 = float4x4(185.966553f, -220.597046f, -228.686859f, -333.001282f, 434.213f, 406.248718f, -239.869781f, 380.93927f, 90.34949f, -361.327942f, -453.599945f, 157.732483f, -491.0462f, 296.614258f, 482.265137f, -305.876984f);
            float b2 = (-102.975983f);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x4 a3 = float4x4(-290.1021f, -110.528351f, 496.8636f, -441.101746f, 50.9035034f, 66.07239f, 455.6059f, -390.0443f, 491.20813f, -498.4148f, 143.113464f, -347.041321f, -146.644165f, -243.853455f, -85.37955f, -438.494019f);
            float b3 = (115.246521f);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4x4_operator_equal_scalar_wide()
        {
            float a0 = (-253.397278f);
            float4x4 b0 = float4x4(19.95221f, -185.791992f, 407.8136f, -87.2767f, -206.274689f, 160.503113f, -274.7708f, -2.63153076f, 448.354553f, -410.035248f, 247.329041f, 355.539124f, -298.0667f, 414.1015f, -481.3026f, 196.55072f);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (34.6010132f);
            float4x4 b1 = float4x4(113.7616f, -386.453369f, -124.49176f, 243.886658f, -492.6182f, 145.424438f, 421.55072f, -95.40997f, 336.809265f, 209.5838f, 487.4414f, 161.806519f, 149.842468f, 225.724f, -71.21881f, 85.78027f);
            bool4x4 r1 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (192.547241f);
            float4x4 b2 = float4x4(-49.88748f, -229.801971f, -103.407349f, 19.21576f, 492.8811f, 140.403137f, -267.536438f, 125.972717f, 478.0005f, 116.144592f, -368.957764f, -225.028656f, 2.723755f, -452.2632f, 87.45654f, 401.306519f);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (-18.6455383f);
            float4x4 b3 = float4x4(-294.214f, -32.7313538f, -1.25234985f, 14.7160645f, 0.570373535f, 180.783569f, 498.262878f, -503.8667f, -31.0839844f, 462.9193f, -250.21225f, 347.561951f, -213.487946f, -123.759247f, -193.452179f, -242.241089f);
            bool4x4 r3 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4x4_operator_not_equal_wide_wide()
        {
            float4x4 a0 = float4x4(430.842529f, 104.69f, 225.802429f, -310.5702f, -418.619446f, 304.128174f, -509.3268f, -160.538086f, -203.301971f, -505.763245f, 162.17218f, 1.156189f, 65.66205f, 102.787781f, 172.930054f, 26.6210327f);
            float4x4 b0 = float4x4(210.024719f, -55.20334f, -269.925354f, -234.546722f, 25.91742f, -63.72699f, -484.5537f, -425.3336f, -53.2743835f, 328.1944f, 15.9631348f, 461.7141f, -113.363037f, -240.072968f, 495.119141f, 203.55835f);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x4 a1 = float4x4(235.125977f, 128.541992f, -354.996979f, 334.3595f, -495.832f, 468.307373f, 458.370972f, 299.937317f, 43.1271973f, -354.7135f, -145.2872f, 390.80188f, -303.13147f, 391.134583f, 139.286865f, 104.523193f);
            float4x4 b1 = float4x4(340.493469f, -241.9072f, 459.569824f, 213.07373f, -384.782837f, -255.072327f, 477.663452f, -248.036621f, -407.923462f, -199.788879f, 151.843262f, -97.1206055f, 154.975891f, -172.834534f, 441.5028f, -401.738617f);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x4 a2 = float4x4(511.2964f, 213.147034f, -101.0957f, 441.6634f, 124.36615f, 312.026428f, 59.65576f, -508.65683f, 98.699646f, 228.799866f, 337.832642f, -163.154449f, 461.6916f, -450.7757f, -443.564758f, -438.213135f);
            float4x4 b2 = float4x4(-411.430176f, -337.820282f, -430.6309f, -150.8718f, -206.837f, 34.95508f, -255.771454f, 99.99866f, -161.175568f, 68.8535156f, -285.590118f, -428.717316f, -286.3374f, 2.02709961f, -4.80599976f, -425.3348f);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x4 a3 = float4x4(22.69397f, -254.368744f, -247.483612f, 365.059082f, -337.586823f, 187.845032f, 351.816833f, 355.223633f, 151.63269f, 240.465881f, -299.297058f, -227.571289f, 263.7243f, -287.511871f, -491.855164f, -219.307037f);
            float4x4 b3 = float4x4(358.046021f, 357.8011f, 125.757629f, -38.2419434f, 308.158325f, -450.4502f, -156.1532f, 464.639954f, -220.864044f, -211.537567f, -476.330353f, 284.886536f, 129.86438f, -326.7583f, -72.36374f, -382.827881f);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4x4_operator_not_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(-16.9145813f, 168.8341f, -462.713531f, 130.307739f, 214.501587f, -440.263275f, -197.12796f, -169.099854f, -386.611176f, -281.021f, -270.26886f, -403.9637f, -269.805725f, 299.654236f, -71.7509155f, -432.755737f);
            float b0 = (-145.372772f);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x4 a1 = float4x4(-457.363129f, 273.873047f, 185.04248f, -482.5307f, 116.395142f, 511.735f, 230.5075f, 100.27478f, 129.682434f, 321.178772f, -220.639f, 140.3352f, 369.212341f, 453.811218f, -333.66626f, -373.937744f);
            float b1 = (-13.5195923f);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x4 a2 = float4x4(150.204285f, 372.32f, -95.83798f, 495.5667f, -5.3855896f, -210.502991f, -459.612732f, 243.309082f, 314.102173f, 96.7449951f, -168.161926f, -71.90546f, 216.608459f, -377.3738f, 142.35498f, -432.272552f);
            float b2 = (-442.164764f);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x4 a3 = float4x4(94.29083f, 337.810547f, -197.6615f, -46.38388f, 250.232056f, 169.099182f, -181.221069f, -481.967f, -427.1808f, -249.442078f, -488.488953f, 202.564941f, -243.823547f, -222.832214f, -448.6026f, 481.974f);
            float b3 = (331.653381f);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4x4_operator_not_equal_scalar_wide()
        {
            float a0 = (275.795837f);
            float4x4 b0 = float4x4(-57.1969f, -382.432526f, 97.82037f, -161.463654f, -458.39563f, -499.617859f, 327.92218f, 367.571228f, 59.786377f, -209.580688f, -62.5804443f, -479.974976f, -49.4945068f, -114.685211f, 109.93927f, -176.284821f);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-347.4853f);
            float4x4 b1 = float4x4(85.5409546f, -356.659546f, -104.243561f, -133.5492f, 243.539734f, 13.1412964f, -379.985962f, -41.28122f, 87.91168f, -339.077271f, -371.820343f, 333.1443f, 294.811951f, -187.14566f, 220.192261f, -228.182068f);
            bool4x4 r1 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-499.723724f);
            float4x4 b2 = float4x4(97.40588f, 501.60437f, 459.6754f, 158.098145f, 358.4886f, 243.512573f, 336.702942f, 89.953125f, -65.57837f, -159.260162f, 410.588562f, 123.963013f, -239.625122f, -299.42984f, -491.2919f, 207.71167f);
            bool4x4 r2 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (271.5655f);
            float4x4 b3 = float4x4(-329.03772f, 461.0074f, -317.160522f, -102.655f, 211.263367f, 116.426147f, -34.1936951f, 391.817566f, -34.307312f, 351.4594f, 187.742554f, -477.573059f, 276.974426f, 489.565f, 229.2273f, 260.2071f);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4x4_operator_less_wide_wide()
        {
            float4x4 a0 = float4x4(196.84259f, 336.4098f, 251.963745f, 257.655945f, 430.0459f, -62.4196472f, 8.839233f, -333.8167f, 164.678833f, -350.9449f, 3.84143066f, 125.409729f, -111.129944f, 70.00549f, 448.1983f, -419.987122f);
            float4x4 b0 = float4x4(-465.345032f, -256.1524f, -314.814026f, 364.5667f, 100.21051f, 182.560974f, 3.11700439f, -259.430481f, -437.3349f, -456.043732f, -394.255981f, 401.9137f, 313.439148f, 121.286682f, -28.0122986f, -282.965881f);
            bool4x4 r0 = bool4x4(false, false, false, true, false, true, false, true, false, false, false, true, true, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x4 a1 = float4x4(-258.301666f, -34.8322144f, -69.8594055f, 67.76721f, -139.777283f, 385.434631f, 133.7074f, 506.188354f, 34.44287f, 412.1137f, -84.8097839f, 444.785339f, -78.75473f, 366.977539f, 127.180481f, 428.368469f);
            float4x4 b1 = float4x4(330.0644f, 124.099365f, -183.6903f, 373.0608f, 109.750916f, -203.57135f, 45.64868f, -360.952271f, 211.913086f, -313.286377f, -259.661072f, 79.09851f, 446.4961f, 450.524536f, -375.630768f, -53.9418335f);
            bool4x4 r1 = bool4x4(true, true, false, true, true, false, false, false, true, false, false, false, true, true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x4 a2 = float4x4(8.197632f, -71.13736f, -474.0508f, 322.4289f, 6.897888f, 195.733582f, -267.6906f, -243.7937f, 319.2508f, -425.1562f, 71.87396f, 313.843872f, 397.279053f, -309.145874f, -38.6678467f, -266.1197f);
            float4x4 b2 = float4x4(-291.453735f, 190.774841f, 54.0839233f, -163.63089f, -212.005646f, 406.0905f, -183.018951f, 355.221375f, -81.0422058f, -275.7148f, 405.299255f, -510.6406f, 398.069275f, -4.35549927f, 129.242676f, -276.146545f);
            bool4x4 r2 = bool4x4(false, true, true, false, false, true, true, true, false, true, true, false, true, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x4 a3 = float4x4(193.3825f, 300.231018f, -395.214f, -398.901428f, 401.4842f, 191.8158f, 56.6053467f, -165.210846f, 178.2898f, -380.726257f, -462.474548f, 386.1842f, -93.29764f, 305.4958f, -148.7702f, 387.037f);
            float4x4 b3 = float4x4(-72.6235352f, -86.83887f, -196.586456f, 492.358948f, 63.74463f, -384.804138f, -473.305145f, -407.7358f, -500.243866f, -303.777344f, 192.083252f, 114.898376f, -72.4967651f, -360.120056f, -185.215576f, 389.6552f);
            bool4x4 r3 = bool4x4(false, false, true, true, false, false, false, false, false, true, true, false, true, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4x4_operator_less_wide_scalar()
        {
            float4x4 a0 = float4x4(-132.057312f, -192.465f, -66.8345947f, -379.017517f, -360.2824f, 20.9278564f, -158.240753f, 437.3459f, -20.4526062f, 225.2915f, 307.4842f, 274.015259f, 373.549683f, 398.523682f, 105.030151f, -58.0108948f);
            float b0 = (-156.010223f);
            bool4x4 r0 = bool4x4(false, true, false, true, true, false, true, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x4 a1 = float4x4(109.670105f, -44.9712524f, 140.426086f, -500.0883f, 172.103333f, -197.500732f, -7.271515f, -432.9905f, 62.1583252f, -72.25473f, -377.852325f, -500.255737f, 149.11499f, 119.880615f, 202.63916f, 274.950684f);
            float b1 = (-108.85318f);
            bool4x4 r1 = bool4x4(false, false, false, true, false, true, false, true, false, false, true, true, false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x4 a2 = float4x4(66.41205f, -149.6358f, 223.758728f, 73.2668457f, 213.094971f, 322.8595f, 418.3772f, 421.103577f, -187.16684f, 389.109436f, 401.335449f, -106.285065f, 380.607971f, 385.652832f, 120.659851f, -13.8308716f);
            float b2 = (274.999451f);
            bool4x4 r2 = bool4x4(true, true, true, true, true, false, false, false, true, false, false, true, false, false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x4 a3 = float4x4(-500.1271f, 431.943665f, 129.688965f, -143.969055f, 183.886414f, -506.964264f, 452.4369f, -458.027f, 89.5592651f, -418.817444f, -292.388428f, 425.601624f, 342.432434f, -406.589142f, -407.155f, 511.064575f);
            float b3 = (487.528259f);
            bool4x4 r3 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4x4_operator_less_scalar_wide()
        {
            float a0 = (-423.1174f);
            float4x4 b0 = float4x4(385.094849f, -123.933472f, 86.37659f, 133.4422f, 161.457947f, 229.754272f, 222.5716f, 315.5312f, -447.203522f, 271.833862f, -393.605316f, 317.486877f, -164.6051f, -282.876038f, 296.979553f, -254.401154f);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (365.6156f);
            float4x4 b1 = float4x4(-441.984253f, -131.42865f, 442.628967f, -29.7928467f, -138.37381f, 9.21698f, -226.73056f, 171.029419f, 376.625244f, -462.5887f, -142.36731f, -456.253784f, 66.61023f, 169.378784f, 327.4444f, 64.08795f);
            bool4x4 r1 = bool4x4(false, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-153.5039f);
            float4x4 b2 = float4x4(199.380127f, -244.969055f, 472.743835f, -363.7801f, -179.487518f, -83.42514f, 178.886475f, 62.15576f, 409.746765f, -117.163666f, 316.601685f, 285.5163f, 18.6745f, 282.5293f, 132.923767f, -318.215332f);
            bool4x4 r2 = bool4x4(true, false, true, false, false, true, true, true, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (314.8399f);
            float4x4 b3 = float4x4(78.00372f, 116.839478f, -134.375641f, 118.675415f, 11.4686279f, 378.849548f, -198.892883f, 474.41272f, 296.8327f, 180.343018f, -147.0611f, 259.7849f, -1.81375122f, -409.5449f, -209.049713f, -258.601f);
            bool4x4 r3 = bool4x4(false, false, false, false, false, true, false, true, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_wide_wide()
        {
            float4x4 a0 = float4x4(483.5014f, 310.8156f, 106.966187f, 295.7353f, 116.957581f, -478.299774f, -14.8974f, -33.8174438f, -24.74054f, 319.782654f, -120.158569f, -289.008575f, 455.85144f, 144.706909f, 63.9320068f, -285.683044f);
            float4x4 b0 = float4x4(-471.398f, -371.9853f, 36.9006958f, -316.7636f, 19.6830444f, 207.309143f, 362.7975f, 324.95343f, 340.948059f, 25.9860229f, -114.211121f, 240.803467f, 273.422424f, 325.515747f, 27.3410645f, 64.47955f);
            bool4x4 r0 = bool4x4(true, true, true, true, true, false, false, false, false, true, false, false, true, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x4 a1 = float4x4(-502.090729f, -337.194458f, 474.317322f, -507.1451f, -133.565582f, -443.109131f, -464.34137f, -68.36154f, -185.993011f, -157.8039f, -74.12424f, -94.47116f, 329.610535f, -315.836731f, 404.1938f, 131.304382f);
            float4x4 b1 = float4x4(200.948364f, 100.122681f, -79.00711f, -315.137939f, -122.985443f, -163.7792f, -492.566f, -90.79727f, -284.901245f, -23.6536865f, 174.93f, 85.7125244f, -441.987823f, 345.543762f, 482.219482f, -422.383484f);
            bool4x4 r1 = bool4x4(false, false, true, false, false, false, true, true, true, false, false, false, true, false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x4 a2 = float4x4(-206.633911f, 197.399841f, 187.991943f, 362.636047f, 336.0932f, -352.448364f, -183.10199f, 193.144836f, -170.216f, -0.491241455f, -326.855042f, -373.39624f, -216.580475f, 282.5121f, -275.170349f, -207.331757f);
            float4x4 b2 = float4x4(-30.7792969f, 296.154236f, 378.059875f, -457.733429f, 122.920593f, -509.173126f, 386.77063f, 436.41748f, -276.495819f, -163.166779f, 249.970642f, -165.020752f, 89.09302f, 404.305176f, -340.688843f, -103.785095f);
            bool4x4 r2 = bool4x4(false, false, false, true, true, true, false, false, true, true, false, false, false, false, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x4 a3 = float4x4(257.710144f, -469.1453f, -177.965851f, 233.210754f, -135.537323f, 152.253113f, 15.378418f, -243.185455f, -123.13266f, 3.75976563f, -29.2892761f, 416.471558f, -169.383057f, 0.7346802f, -416.4522f, 329.4369f);
            float4x4 b3 = float4x4(491.274353f, 78.43793f, 147.484192f, -52.052887f, -212.070465f, 314.9552f, -97.2980347f, 454.8399f, -240.254211f, 168.689636f, -217.528809f, 55.3954468f, -149.5794f, -413.101044f, 470.330933f, 164.782043f);
            bool4x4 r3 = bool4x4(false, false, false, true, true, false, true, false, true, false, true, true, false, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_wide_scalar()
        {
            float4x4 a0 = float4x4(64.31793f, -397.703461f, 431.8769f, 85.703f, 246.263062f, 197.491577f, 286.199463f, 280.813354f, -405.7846f, 171.565369f, -241.807281f, 333.5782f, 370.279175f, -413.7014f, -356.592346f, -353.0313f);
            float b0 = (305.859924f);
            bool4x4 r0 = bool4x4(false, false, true, false, false, false, false, false, false, false, false, true, true, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x4 a1 = float4x4(396.645325f, -240.013428f, 502.915039f, 315.4676f, -259.2897f, 281.230652f, 428.792175f, 245.153076f, -279.1754f, -453.8631f, -124.771545f, -425.652924f, 99.13287f, 355.060547f, -456.439423f, 154.489014f);
            float b1 = (467.222046f);
            bool4x4 r1 = bool4x4(false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x4 a2 = float4x4(405.529724f, 186.0863f, 249.999084f, -110.096924f, -435.3045f, 72.7520142f, -254.346558f, -428.987946f, 255.373657f, -309.1123f, 185.501587f, -201.334167f, 23.321167f, -143.9761f, -111.77951f, -356.656616f);
            float b2 = (-157.7338f);
            bool4x4 r2 = bool4x4(true, true, true, true, false, true, false, false, true, false, true, false, true, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x4 a3 = float4x4(-318.313568f, 490.187134f, -305.578979f, 260.850342f, 53.1495972f, -166.934113f, -508.915283f, 352.549927f, 13.4384766f, 139.354675f, -101.028992f, 194.466309f, 7.08258057f, 328.504883f, -297.367859f, -332.910828f);
            float b3 = (287.207642f);
            bool4x4 r3 = bool4x4(false, true, false, false, false, false, false, true, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_scalar_wide()
        {
            float a0 = (-282.6705f);
            float4x4 b0 = float4x4(358.099976f, -72.596405f, -232.163788f, -60.7067261f, 75.15662f, 150.883484f, 339.539185f, -498.196045f, 459.7461f, -227.968719f, 335.862122f, 76.17883f, 296.859924f, 177.48999f, -281.2012f, 244.722839f);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (137.328552f);
            float4x4 b1 = float4x4(-385.338257f, 443.163452f, -353.562561f, 26.04065f, -331.793945f, -43.6919556f, 20.9494019f, -211.17984f, 227.421692f, -84.7797852f, -375.1355f, -205.178131f, -197.04715f, -219.634033f, -210.015625f, -266.7737f);
            bool4x4 r1 = bool4x4(true, false, true, true, true, true, true, true, false, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (144.7785f);
            float4x4 b2 = float4x4(-471.7112f, -155.913177f, 99.72473f, -230.944855f, -338.8689f, 334.068237f, -158.660858f, -315.018219f, -177.19281f, 171.95929f, 198.38916f, 303.678345f, 400.6996f, 351.878662f, -31.7696533f, 386.0733f);
            bool4x4 r2 = bool4x4(true, true, true, true, true, false, true, true, true, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-360.348877f);
            float4x4 b3 = float4x4(-499.8237f, 428.290344f, 425.8302f, 203.288818f, 177.893921f, 483.09552f, 258.88678f, -361.5269f, 359.734924f, -276.336731f, 202.674683f, 218.982117f, 144.793274f, 503.665283f, 33.8777466f, -169.047455f);
            bool4x4 r3 = bool4x4(true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4x4_operator_less_equal_wide_wide()
        {
            float4x4 a0 = float4x4(-438.523132f, 210.489441f, 4.87731934f, -137.297943f, 156.094116f, -363.924133f, -97.94849f, 437.2954f, 458.530273f, -294.064758f, 23.62262f, -34.2840576f, 149.736511f, -418.8867f, -197.502533f, -88.2055054f);
            float4x4 b0 = float4x4(-474.814148f, 304.371033f, 234.824158f, -390.485443f, -297.175354f, -326.2924f, 107.253906f, -413.131073f, 67.09442f, 470.075256f, -84.499115f, 392.784241f, -263.531738f, 369.3009f, -333.3253f, 238.413452f);
            bool4x4 r0 = bool4x4(false, true, true, false, false, true, true, false, false, true, false, true, false, true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x4 a1 = float4x4(-376.71814f, 341.627136f, -83.30917f, -107.490723f, 319.466858f, 205.357361f, 345.563721f, 395.3219f, -222.874146f, 439.022034f, -368.075562f, -200.0386f, 71.46991f, -357.365417f, 141.710876f, 319.0171f);
            float4x4 b1 = float4x4(486.2426f, 279.6502f, 236.052f, 132.758972f, 66.29474f, 183.002136f, 200.130554f, 339.043823f, 438.5379f, 145.401855f, 178.163086f, 157.975952f, 329.7052f, -243.590912f, 5.401184f, -22.5805969f);
            bool4x4 r1 = bool4x4(true, false, true, true, false, false, false, false, true, false, true, true, true, true, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x4 a2 = float4x4(303.030151f, -461.574249f, 277.62677f, 182.1781f, -337.414856f, -361.391663f, 222.1435f, -464.7795f, -146.853668f, 80.17505f, -260.3473f, 94.48901f, 174.281189f, -303.8197f, 81.41742f, 503.048157f);
            float4x4 b2 = float4x4(-90.3375854f, -72.19107f, -354.354828f, -289.521729f, 85.17627f, 469.327881f, 294.7138f, 461.605957f, -245.930481f, -124.040436f, 278.392639f, -42.8812561f, -328.348816f, 98.9855957f, -375.899841f, -197.934265f);
            bool4x4 r2 = bool4x4(false, true, false, false, true, true, true, true, false, false, true, false, false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x4 a3 = float4x4(259.2776f, 391.971924f, 149.704773f, -450.582947f, -255.6402f, -29.1832886f, 27.5547485f, 447.832458f, 282.48468f, 415.262756f, 437.226135f, -274.2333f, 327.17334f, 265.5277f, 461.464844f, 141.060852f);
            float4x4 b3 = float4x4(-284.062f, -76.09866f, -44.487f, -380.519348f, 216.543762f, 58.74817f, -157.366516f, 288.756042f, -306.971375f, -124.358673f, -68.9424438f, -487.362457f, 93.30701f, 93.9755859f, -428.8075f, -473.515f);
            bool4x4 r3 = bool4x4(false, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4x4_operator_less_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(193.49585f, 168.915527f, -313.993073f, 81.8269653f, 18.5036011f, -0.3581848f, 241.361145f, -463.8164f, -1.35775757f, -268.899475f, 398.991943f, -471.253082f, -264.9378f, 82.2583f, 11.2460327f, 424.704041f);
            float b0 = (443.850525f);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x4 a1 = float4x4(426.482239f, -196.2879f, 31.9011841f, -152.257568f, -437.926453f, -37.1048279f, -47.1442261f, 333.623047f, -274.8039f, 358.67627f, -260.460571f, 192.309143f, 145.306091f, -466.132965f, -494.267334f, -111.570129f);
            float b1 = (56.3200073f);
            bool4x4 r1 = bool4x4(false, true, true, true, true, true, true, false, true, false, true, false, false, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x4 a2 = float4x4(-139.5412f, 33.98401f, -445.704468f, -451.0422f, -122.039276f, 83.3277f, -202.465515f, -76.56488f, 218.032776f, -103.53595f, -283.358429f, -374.761658f, -213.49588f, 477.491821f, -383.370056f, 23.9649658f);
            float b2 = (-146.589355f);
            bool4x4 r2 = bool4x4(false, false, true, true, false, false, true, false, false, false, true, true, true, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x4 a3 = float4x4(-5.960785f, 164.991455f, -117.631805f, -166.246613f, 369.776978f, -305.9796f, 245.151123f, 260.203918f, -218.692535f, 152.965515f, -10.1782837f, -144.12558f, 365.336182f, -314.766479f, 381.259277f, 152.317078f);
            float b3 = (-283.961731f);
            bool4x4 r3 = bool4x4(false, false, false, false, false, true, false, false, false, false, false, false, false, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4x4_operator_less_equal_scalar_wide()
        {
            float a0 = (393.606262f);
            float4x4 b0 = float4x4(-75.6883545f, -44.2638855f, 125.864929f, 191.9649f, 13.54303f, -197.051941f, -423.9451f, -330.0486f, 420.165527f, 105.5473f, 174.821289f, 296.7176f, -469.7004f, 123.267212f, 112.996948f, 495.143372f);
            bool4x4 r0 = bool4x4(false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (-488.6579f);
            float4x4 b1 = float4x4(388.539429f, -493.240784f, 16.45105f, -387.651642f, -229.1773f, -373.01532f, -391.142151f, 90.99414f, -178.396149f, -69.62106f, 471.790833f, -67.46677f, 45.30536f, -154.6922f, 385.7389f, -431.652954f);
            bool4x4 r1 = bool4x4(true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-331.673035f);
            float4x4 b2 = float4x4(-349.8927f, -114.839142f, -245.217834f, -486.6955f, 391.950928f, -125.770538f, -229.812286f, 289.449036f, -200.494232f, 281.5927f, 99.90106f, -146.027435f, 124.148376f, 94.3569946f, 93.920105f, -484.924133f);
            bool4x4 r2 = bool4x4(false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-270.796875f);
            float4x4 b3 = float4x4(-313.374084f, 252.967834f, -302.899719f, 269.257874f, -358.511047f, -183.248535f, 5.00708f, -411.029266f, -320.0608f, 384.569153f, -383.735962f, 249.418152f, -137.139832f, -251.7605f, 301.0824f, 216.370544f);
            bool4x4 r3 = bool4x4(false, true, false, true, false, true, true, false, false, true, false, true, true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_equal_wide_wide()
        {
            float4x4 a0 = float4x4(-507.9286f, 504.4975f, -385.4345f, -262.323425f, -37.5509338f, -111.595276f, -463.702026f, 387.448853f, 456.9688f, -211.010162f, 182.411377f, -53.59604f, -309.570221f, -136.022491f, 280.736267f, -96.99588f);
            float4x4 b0 = float4x4(-81.3465f, 297.666138f, 171.06543f, -431.038055f, -6.85907f, 319.7257f, 254.079163f, 396.5724f, 178.8393f, -447.063354f, 288.492676f, 474.889282f, -321.750244f, -395.977234f, -158.692474f, 391.4887f);
            bool4x4 r0 = bool4x4(false, true, false, true, false, false, false, false, true, true, false, false, true, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x4 a1 = float4x4(-174.059509f, 88.90192f, 43.81604f, -446.07843f, 16.6455688f, 409.83252f, -191.329865f, 222.9978f, 404.2884f, 230.603271f, -441.789276f, -86.29306f, 484.249573f, 95.23639f, -204.912109f, -199.774353f);
            float4x4 b1 = float4x4(-368.109253f, 89.12378f, -510.279327f, -486.9298f, -81.2155457f, 274.2188f, -212.881561f, 288.9953f, 307.73175f, 307.245178f, -199.391785f, -284.421265f, -482.3918f, 448.315735f, -378.3462f, -390.858459f);
            bool4x4 r1 = bool4x4(true, false, true, true, true, true, true, false, true, false, false, true, true, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x4 a2 = float4x4(-421.8632f, -18.2147827f, -346.822754f, -159.243652f, 112.917725f, 48.2910156f, 390.660156f, 154.219177f, -32.7480469f, -288.265625f, 122.704285f, 321.277954f, 230.183838f, 116.874268f, -93.515686f, 229.9823f);
            float4x4 b2 = float4x4(8.916016f, 416.407227f, -213.674957f, 455.2481f, -236.080353f, -248.373108f, 184.18512f, 415.31134f, 86.98218f, 485.004578f, 107.758911f, -486.667725f, -138.676788f, 14.2078247f, -382.394165f, -117.008209f);
            bool4x4 r2 = bool4x4(false, false, false, false, true, true, true, false, false, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x4 a3 = float4x4(-393.441223f, 184.082031f, 317.333252f, 123.818054f, -45.0246277f, -317.672546f, 264.3172f, -163.081421f, -124.610992f, -30.9362183f, 421.919434f, -1.56271362f, 199.638062f, -325.7766f, 181.4508f, 36.7637939f);
            float4x4 b3 = float4x4(288.690979f, 311.7541f, 318.590576f, 105.963318f, 287.355164f, 306.291077f, -349.919983f, -211.935577f, 191.925049f, 220.105713f, -172.7789f, -17.6221313f, -43.54706f, 303.854f, 338.548523f, -16.68814f);
            bool4x4 r3 = bool4x4(false, false, false, true, false, false, true, true, false, false, true, true, true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(465.152161f, -424.886078f, -209.2211f, 58.7798462f, -302.2691f, 140.12561f, 16.3533936f, -344.559967f, 393.278076f, -315.701538f, 441.011536f, -509.781555f, -36.9942932f, 494.8203f, -164.973938f, -466.1201f);
            float b0 = (-5.599884f);
            bool4x4 r0 = bool4x4(true, false, false, true, false, true, true, false, true, false, true, false, false, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x4 a1 = float4x4(-123.813751f, 104.995728f, 314.346f, 190.516113f, -83.11142f, -23.8364258f, 143.049377f, -264.919983f, -169.702209f, 329.70752f, 359.095825f, -260.4233f, 354.195129f, -111.845337f, 33.309082f, 355.6313f);
            float b1 = (215.651245f);
            bool4x4 r1 = bool4x4(false, false, true, false, false, false, false, false, false, true, true, false, true, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x4 a2 = float4x4(-435.360565f, -93.2957153f, -338.8496f, 436.8958f, 511.084167f, -277.67453f, -453.799255f, 170.919f, -182.825745f, -207.516937f, -319.5006f, -240.5086f, 436.3413f, -66.9560547f, 303.320862f, 180.196045f);
            float b2 = (-38.3993225f);
            bool4x4 r2 = bool4x4(false, false, false, true, true, false, false, true, false, false, false, false, true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x4 a3 = float4x4(337.965149f, 107.356689f, -501.208679f, -237.363922f, -434.488464f, 110.950378f, 159.729553f, -188.300171f, 379.4331f, 322.4181f, 169.257568f, 427.863342f, -472.917084f, 308.1438f, -104.297546f, -353.412842f);
            float b3 = (-84.43594f);
            bool4x4 r3 = bool4x4(true, true, false, false, false, true, true, false, true, true, true, true, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_equal_scalar_wide()
        {
            float a0 = (374.827026f);
            float4x4 b0 = float4x4(-1.60977173f, 338.615234f, -116.1814f, -332.157318f, -355.97937f, -468.901428f, 38.579895f, -332.347534f, 2.89013672f, 467.777771f, 121.406372f, -305.023376f, -58.4288025f, -226.519562f, -47.0209961f, 305.302673f);
            bool4x4 r0 = bool4x4(true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-427.401245f);
            float4x4 b1 = float4x4(92.26367f, -497.178528f, -408.625641f, -455.2305f, 396.4261f, -469.2949f, -485.754028f, -182.346191f, -291.545349f, 278.740784f, -75.8711243f, 28.9070435f, 287.720154f, 420.509766f, 473.626831f, 181.514526f);
            bool4x4 r1 = bool4x4(false, true, false, true, false, true, true, false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-369.202881f);
            float4x4 b2 = float4x4(243.749756f, -244.124146f, -242.993347f, -322.115356f, 192.974976f, -54.7255554f, -166.000824f, 244.293457f, 438.2494f, -162.692841f, 37.1853638f, -506.667358f, -205.163086f, 368.389954f, -35.45996f, -20.9164429f);
            bool4x4 r2 = bool4x4(false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (9.041382f);
            float4x4 b3 = float4x4(-377.5871f, -18.9806213f, 59.2191162f, 318.0575f, 113.964172f, 295.910156f, -142.4274f, 362.188843f, 447.56604f, -235.642242f, -397.548981f, 150.745422f, 227.169983f, -464.732025f, 159.779541f, 25.4620972f);
            bool4x4 r3 = bool4x4(true, true, false, false, false, false, true, false, false, true, true, false, false, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4x4_operator_add_wide_wide()
        {
            float4x4 a0 = float4x4(506.129028f, -501.779816f, 420.084778f, -186.032074f, -9.312408f, 328.51178f, 424.344055f, 87.79108f, 462.4137f, -46.17871f, 401.170044f, -454.124146f, 69.19568f, -177.957336f, 299.604126f, 340.704834f);
            float4x4 b0 = float4x4(-28.7579956f, -337.135132f, -340.676819f, 152.312012f, 423.66748f, 90.3740845f, 376.18866f, 1.76721191f, -120.185852f, -279.629364f, -344.6671f, 242.839172f, 418.593079f, -23.3128052f, -95.0999451f, 147.9281f);
            float4x4 r0 = float4x4(477.371033f, -838.9149f, 79.40796f, -33.7200623f, 414.355072f, 418.885864f, 800.5327f, 89.55829f, 342.227844f, -325.808075f, 56.50293f, -211.284973f, 487.788757f, -201.270142f, 204.504181f, 488.632935f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x4 a1 = float4x4(219.916016f, -321.9084f, 286.355347f, -333.4195f, -118.932159f, 68.60748f, 23.190918f, -205.577881f, 11.5214233f, -340.795074f, -68.93118f, 304.8532f, -86.63385f, 105.669128f, 349.280518f, 364.7079f);
            float4x4 b1 = float4x4(331.0329f, -82.50256f, 279.4496f, 342.622742f, -300.358521f, -209.694092f, 446.559448f, -351.9892f, -263.12384f, -252.458557f, 289.825378f, 338.796143f, -232.619019f, -510.50824f, 349.280762f, -426.212463f);
            float4x4 r1 = float4x4(550.9489f, -404.41095f, 565.804932f, 9.203247f, -419.29068f, -141.086609f, 469.750366f, -557.5671f, -251.602417f, -593.253662f, 220.8942f, 643.649353f, -319.252869f, -404.8391f, 698.5613f, -61.5045776f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x4 a2 = float4x4(-429.0374f, 382.458069f, 186.097046f, 227.411865f, -298.766357f, 351.3028f, 98.7254f, -292.351685f, 112.1709f, 477.165771f, -266.304871f, -295.1407f, -485.820374f, -507.8687f, -338.2196f, 505.342163f);
            float4x4 b2 = float4x4(-331.416321f, -418.6888f, -341.70636f, -329.0359f, 123.198547f, 189.528564f, 267.569946f, 134.636292f, -337.96814f, 50.7280273f, 81.16345f, 442.0907f, -148.704529f, 6.974365f, -334.911255f, 43.78711f);
            float4x4 r2 = float4x4(-760.453735f, -36.2307434f, -155.609314f, -101.624023f, -175.56781f, 540.83136f, 366.295349f, -157.7154f, -225.797241f, 527.8938f, -185.141418f, 146.950012f, -634.5249f, -500.894348f, -673.130859f, 549.1293f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x4 a3 = float4x4(-153.0664f, -292.656677f, -447.898651f, -26.0862427f, 21.4642944f, -465.6922f, 450.522522f, -271.92923f, -452.2673f, -110.679169f, 384.114929f, 352.0924f, 475.724365f, -444.868439f, -345.837646f, -502.816284f);
            float4x4 b3 = float4x4(-17.1800537f, -157.392761f, -298.889069f, -158.772217f, 500.240784f, 319.870239f, -396.675354f, 157.7962f, 483.0329f, 175.248657f, -198.020142f, 1.79919434f, 452.367371f, -177.198425f, -291.5625f, -475.855133f);
            float4x4 r3 = float4x4(-170.24646f, -450.049438f, -746.7877f, -184.858459f, 521.7051f, -145.82196f, 53.847168f, -114.133026f, 30.7655945f, 64.56949f, 186.094788f, 353.8916f, 928.091736f, -622.0669f, -637.400146f, -978.6714f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4x4_operator_add_wide_scalar()
        {
            float4x4 a0 = float4x4(-194.514191f, 338.5484f, 246.971375f, 100.510925f, -45.72467f, -478.1113f, 30.9161377f, 60.37433f, -242.118744f, 82.50134f, 6.79937744f, -484.6998f, -188.265015f, -213.526733f, -267.7843f, 189.259949f);
            float b0 = (124.121704f);
            float4x4 r0 = float4x4(-70.39249f, 462.6701f, 371.093079f, 224.632629f, 78.39703f, -353.9896f, 155.037842f, 184.496033f, -117.99704f, 206.623047f, 130.921082f, -360.5781f, -64.14331f, -89.40503f, -143.6626f, 313.381653f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x4 a1 = float4x4(198.533569f, -424.925659f, 302.102356f, 300.3991f, 124.021606f, -200.161346f, 31.3782349f, 362.522156f, -423.988861f, 432.41333f, 374.211426f, -465.6995f, -311.04303f, 84.91901f, -432.442444f, 235.750671f);
            float b1 = (187.536072f);
            float4x4 r1 = float4x4(386.069641f, -237.389587f, 489.638428f, 487.935181f, 311.557678f, -12.6252747f, 218.9143f, 550.0582f, -236.452789f, 619.9494f, 561.7475f, -278.163422f, -123.506958f, 272.455078f, -244.906372f, 423.286743f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x4 a2 = float4x4(-472.637756f, 186.120728f, -170.298218f, -115.272491f, -101.168823f, 257.775146f, 246.549255f, -397.5346f, -199.04837f, 20.585022f, 207.323853f, 197.935181f, -201.540558f, -106.638672f, -179.382233f, 203.817078f);
            float b2 = (-257.577759f);
            float4x4 r2 = float4x4(-730.2155f, -71.45703f, -427.875977f, -372.85025f, -358.746582f, 0.1973877f, -11.0285034f, -655.112366f, -456.626129f, -236.992737f, -50.2539063f, -59.64258f, -459.118317f, -364.216431f, -436.96f, -53.76068f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x4 a3 = float4x4(-364.820953f, 77.39429f, 185.278931f, 17.086731f, -511.8999f, 26.7097168f, -296.40683f, 249.988831f, -133.735809f, -398.524628f, 168.704712f, 14.0738525f, -443.0757f, 509.582336f, -72.75815f, -208.45047f);
            float b3 = (154.526245f);
            float4x4 r3 = float4x4(-210.294708f, 231.920532f, 339.805176f, 171.612976f, -357.373657f, 181.235962f, -141.880585f, 404.515076f, 20.7904358f, -243.998383f, 323.230957f, 168.6001f, -288.549469f, 664.1086f, 81.7681f, -53.9242249f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4x4_operator_add_scalar_wide()
        {
            float a0 = (-340.354675f);
            float4x4 b0 = float4x4(511.362244f, -146.216644f, -106.210419f, -363.450256f, 199.0896f, -27.1083984f, 419.849f, 284.955017f, -164.9242f, -249.190338f, 150.928162f, 298.1751f, -457.1534f, 424.718079f, -301.857483f, 230.288879f);
            float4x4 r0 = float4x4(171.007568f, -486.57132f, -446.5651f, -703.804932f, -141.265076f, -367.463074f, 79.49432f, -55.39966f, -505.27887f, -589.545044f, -189.426514f, -42.1795654f, -797.508057f, 84.3634f, -642.212158f, -110.065796f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-423.5876f);
            float4x4 b1 = float4x4(-67.06003f, 68.72412f, -164.02243f, 318.935181f, 7.80456543f, 187.698364f, -3.656952f, -446.083069f, -209.287231f, -38.21289f, -346.257172f, 465.607422f, -192.185944f, 278.6938f, 381.978455f, 481.243652f);
            float4x4 r1 = float4x4(-490.6476f, -354.863464f, -587.61f, -104.652405f, -415.78302f, -235.889221f, -427.244537f, -869.670654f, -632.8748f, -461.800476f, -769.8447f, 42.0198364f, -615.77356f, -144.8938f, -41.60913f, 57.6560669f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-97.22815f);
            float4x4 b2 = float4x4(-455.513733f, 501.834961f, 358.7066f, 430.699768f, 256.987183f, 207.651672f, -376.965179f, -428.085327f, -373.49353f, -468.89328f, -467.658447f, 297.484924f, -506.89978f, -233.358459f, 434.558777f, -387.3152f);
            float4x4 r2 = float4x4(-552.7419f, 404.6068f, 261.478455f, 333.471619f, 159.759033f, 110.423523f, -474.193329f, -525.3135f, -470.72168f, -566.12146f, -564.8866f, 200.256775f, -604.1279f, -330.5866f, 337.330627f, -484.543335f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (171.590271f);
            float4x4 b3 = float4x4(245.057556f, 200.502747f, 353.496826f, -147.289825f, -8.442291f, 178.085022f, 409.446533f, -429.3672f, -103.623169f, -500.8955f, 254.1062f, 331.3476f, -484.73822f, -15.8841248f, 280.9497f, 328.9314f);
            float4x4 r3 = float4x4(416.647827f, 372.093018f, 525.0871f, 24.3004456f, 163.14798f, 349.6753f, 581.0368f, -257.776917f, 67.9671f, -329.305237f, 425.696472f, 502.937866f, -313.147949f, 155.706146f, 452.539978f, 500.521667f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4x4_operator_sub_wide_wide()
        {
            float4x4 a0 = float4x4(160.492249f, 11.223938f, 359.200134f, -498.2283f, -355.253632f, -94.53485f, -410.46405f, -401.384644f, 317.706848f, 447.060425f, -489.074158f, -230.008392f, 24.8754272f, 366.614441f, -107.374146f, -219.008148f);
            float4x4 b0 = float4x4(115.46875f, -130.9823f, 241.540833f, 9.987061f, 419.895142f, 59.12445f, -402.381653f, -75.37015f, 320.9796f, -73.90875f, -31.4447327f, -389.251953f, -375.028839f, 259.182739f, 276.648682f, -453.0692f);
            float4x4 r0 = float4x4(45.0235f, 142.206238f, 117.6593f, -508.215363f, -775.1488f, -153.6593f, -8.082397f, -326.0145f, -3.272766f, 520.9692f, -457.629425f, 159.243561f, 399.904266f, 107.4317f, -384.022827f, 234.061066f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x4 a1 = float4x4(473.9076f, 259.63623f, -360.119629f, 7.80963135f, 437.428467f, -59.1991577f, 418.744324f, 183.142151f, 271.230347f, 496.208557f, 165.354919f, -227.403656f, -166.522858f, 356.142273f, 386.9264f, -394.638763f);
            float4x4 b1 = float4x4(-272.576538f, -191.148041f, 87.1369f, 430.02478f, 343.6571f, 121.029419f, -354.188171f, 249.052f, -2.22543335f, 22.4472656f, 478.112976f, -320.063f, -111.524109f, 222.228943f, -245.411072f, -119.902283f);
            float4x4 r1 = float4x4(746.484131f, 450.784271f, -447.256531f, -422.215149f, 93.77136f, -180.228577f, 772.9325f, -65.90985f, 273.45578f, 473.7613f, -312.758057f, 92.65933f, -54.99875f, 133.91333f, 632.337463f, -274.736481f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x4 a2 = float4x4(126.903259f, 97.21692f, -150.017853f, -227.250519f, -198.830017f, 0.662780762f, -484.245575f, -295.996277f, -46.17099f, 499.9524f, 292.440125f, -106.424133f, 466.827148f, 487.374817f, 242.994629f, -468.901581f);
            float4x4 b2 = float4x4(-153.465668f, 374.1125f, 301.763428f, -281.430054f, -494.964355f, -320.731262f, 160.962219f, -132.9364f, -394.437531f, 406.851257f, 270.544617f, 507.794617f, 67.69922f, 263.40448f, 297.5807f, 170.839539f);
            float4x4 r2 = float4x4(280.368927f, -276.895569f, -451.781281f, 54.1795349f, 296.134338f, 321.394043f, -645.207764f, -163.059875f, 348.266541f, 93.1011353f, 21.8955078f, -614.21875f, 399.12793f, 223.970337f, -54.58606f, -639.7411f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x4 a3 = float4x4(226.2959f, 506.12616f, 60.59491f, -112.930145f, -286.9749f, -290.722748f, -34.5498047f, -347.817444f, -327.527832f, -243.600067f, -233.363464f, 99.65759f, 464.9585f, 419.285339f, 326.3886f, -12.4246826f);
            float4x4 b3 = float4x4(-451.296875f, 60.20996f, 321.029663f, 481.46698f, 265.6386f, 148.319275f, -418.672424f, 184.514954f, -22.9213257f, 269.3639f, -289.490051f, 368.358643f, 101.4223f, 294.282959f, 21.3450317f, 15.5893555f);
            float4x4 r3 = float4x4(677.5928f, 445.9162f, -260.434753f, -594.3971f, -552.6135f, -439.042023f, 384.12262f, -532.3324f, -304.6065f, -512.964f, 56.1265869f, -268.70105f, 363.5362f, 125.00238f, 305.043579f, -28.0140381f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4x4_operator_sub_wide_scalar()
        {
            float4x4 a0 = float4x4(207.389587f, 248.457764f, -384.8239f, -205.344757f, -374.811554f, 191.642029f, 18.8562622f, -44.96161f, 480.857971f, 16.3381958f, -366.865448f, -35.5231f, 349.397766f, 439.077271f, 490.2223f, 195.024048f);
            float b0 = (-36.1124878f);
            float4x4 r0 = float4x4(243.502075f, 284.570251f, -348.711426f, -169.232269f, -338.699066f, 227.754517f, 54.96875f, -8.849121f, 516.970459f, 52.4506836f, -330.75296f, 0.589386f, 385.510254f, 475.189758f, 526.3348f, 231.136536f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x4 a1 = float4x4(-384.849426f, 55.6027832f, -54.931488f, 53.0880737f, 316.8025f, -273.8067f, 256.8872f, 297.173645f, 101.829041f, 136.607971f, -19.7322083f, 336.589722f, -51.8765564f, 317.345764f, -467.055939f, -50.1670532f);
            float b1 = (189.05188f);
            float4x4 r1 = float4x4(-573.9013f, -133.4491f, -243.983368f, -135.9638f, 127.75061f, -462.858582f, 67.83533f, 108.121765f, -87.22284f, -52.44391f, -208.784088f, 147.537842f, -240.928436f, 128.293884f, -656.1078f, -239.218933f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x4 a2 = float4x4(477.804565f, 0.4111328f, 46.66095f, -19.241394f, 396.809753f, 69.5905151f, -334.274231f, -198.077148f, -239.200623f, -339.6812f, -14.5144348f, 219.99707f, -180.260681f, -438.8906f, 186.35553f, -365.066772f);
            float b2 = (-60.82193f);
            float4x4 r2 = float4x4(538.626465f, 61.2330627f, 107.48288f, 41.5805359f, 457.631683f, 130.412445f, -273.4523f, -137.255219f, -178.3787f, -278.859283f, 46.3074951f, 280.819f, -119.438751f, -378.068665f, 247.17746f, -304.244843f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x4 a3 = float4x4(-478.801239f, 57.5604858f, 306.905945f, -357.698456f, 159.085022f, 10.2644653f, -129.711182f, 9.481628f, 35.359436f, -456.9659f, -473.41156f, 130.448669f, 20.7345581f, 210.992432f, -411.8095f, -497.356018f);
            float b3 = (-193.226776f);
            float4x4 r3 = float4x4(-285.574463f, 250.787262f, 500.132721f, -164.47168f, 352.3118f, 203.491241f, 63.5155945f, 202.7084f, 228.586212f, -263.739136f, -280.184784f, 323.675446f, 213.961334f, 404.2192f, -218.582733f, -304.129242f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4x4_operator_sub_scalar_wide()
        {
            float a0 = (-86.00824f);
            float4x4 b0 = float4x4(466.4251f, 298.486938f, -300.9501f, 315.38f, -381.092163f, -125.008362f, 58.4661865f, 214.7461f, -257.549438f, 480.2246f, -443.355072f, 260.795044f, 29.6819458f, 139.857727f, -247.789948f, -248.466217f);
            float4x4 r0 = float4x4(-552.43335f, -384.495178f, 214.941864f, -401.388245f, 295.083923f, 39.0001221f, -144.474426f, -300.754333f, 171.5412f, -566.232849f, 357.346832f, -346.803284f, -115.690186f, -225.865967f, 161.781708f, 162.457977f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (91.44513f);
            float4x4 b1 = float4x4(86.3841553f, 373.8183f, 260.411926f, 114.353943f, -464.405457f, -109.741455f, -311.675354f, 107.864014f, -258.795166f, 14.0975342f, -461.970184f, 30.3108521f, 63.70111f, -462.676758f, 39.75946f, 47.99817f);
            float4x4 r1 = float4x4(5.060974f, -282.373169f, -168.9668f, -22.9088135f, 555.8506f, 201.186584f, 403.120483f, -16.4188843f, 350.2403f, 77.3475952f, 553.4153f, 61.1342773f, 27.7440186f, 554.1219f, 51.68567f, 43.44696f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-177.6193f);
            float4x4 b2 = float4x4(202.477051f, -289.3088f, -459.9254f, 248.386658f, 85.32971f, -73.37479f, -510.652f, 426.963257f, 239.59021f, 477.852356f, 256.0136f, 338.620361f, -483.8312f, 330.3922f, -263.4182f, 123.92804f);
            float4x4 r2 = float4x4(-380.096344f, 111.689514f, 282.306122f, -426.005951f, -262.949f, -104.244507f, 333.0327f, -604.5825f, -417.2095f, -655.4717f, -433.6329f, -516.2396f, 306.2119f, -508.0115f, 85.79892f, -301.547333f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (-269.115967f);
            float4x4 b3 = float4x4(-265.6382f, 484.580322f, -304.015625f, 311.637817f, 418.830566f, -103.771606f, -501.27475f, -304.483978f, 389.703f, 372.894043f, 8.436401f, -327.564758f, 190.749451f, 430.901367f, 28.885437f, -299.203125f);
            float4x4 r3 = float4x4(-3.47775269f, -753.6963f, 34.89966f, -580.7538f, -687.946533f, -165.34436f, 232.158783f, 35.36801f, -658.819f, -642.01f, -277.552368f, 58.44879f, -459.865417f, -700.017334f, -298.0014f, 30.0871582f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4x4_operator_mul_wide_wide()
        {
            float4x4 a0 = float4x4(-482.7138f, -407.2935f, 137.700562f, 208.541138f, 194.29657f, -484.242432f, 183.9873f, -241.33548f, 45.8687744f, 363.3261f, -328.118958f, -471.023071f, -262.682556f, -379.262756f, -374.090576f, 481.4474f);
            float4x4 b0 = float4x4(-236.367889f, 260.7276f, -416.3863f, -364.4956f, -253.147522f, -369.202881f, 193.547913f, 169.0849f, 201.969666f, 249.456055f, -308.193176f, -385.579651f, -183.2796f, 22.2756348f, -265.521423f, -95.67746f);
            float4x4 r0 = float4x4(114098.047f, -106192.656f, -57336.625f, -76012.33f, -49185.6953f, 178783.7f, 35610.36f, -40806.1836f, 9264.101f, 90633.9f, 101124.023f, 181616.9f, 48144.3555f, -8448.318f, 99329.06f, -46063.6641f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x4 a1 = float4x4(104.628052f, 412.935425f, 477.877258f, 20.3778076f, 291.995972f, -138.488312f, -393.464966f, 9.363098f, -131.942291f, 364.449646f, 390.615967f, 418.797974f, -277.3448f, 11.4101563f, 474.876465f, -502.405029f);
            float4x4 b1 = float4x4(133.2544f, 148.311462f, 249.284119f, 500.0055f, -19.3315735f, -36.69107f, 30.5238037f, -401.367f, 3.43725586f, 257.24176f, -290.971924f, 337.47937f, 490.286133f, -191.0198f, -325.7345f, -52.1819763f);
            float4x4 r1 = float4x4(13942.1475f, 61243.06f, 119127.211f, 10189.0156f, -5644.7417f, 5081.284f, -12010.0479f, -3758.03857f, -453.5194f, 93751.67f, -113658.281f, 141335.672f, -135978.3f, -2179.566f, -154683.641f, 26216.4883f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x4 a2 = float4x4(-222.59491f, 38.1690674f, 292.6125f, 203.2077f, -330.408142f, 469.460144f, 342.2951f, -504.114655f, 319.3573f, -357.782074f, -117.9711f, 25.706543f, 226.456421f, -86.34372f, -274.126038f, -486.870972f);
            float4x4 b2 = float4x4(123.435059f, -461.267059f, 122.353088f, 308.584656f, 375.320618f, 203.212646f, 77.66797f, 218.793579f, -489.895752f, 134.472168f, -287.794373f, -116.399994f, -436.543976f, 499.591064f, -300.602356f, 105.730469f);
            float4x4 r2 = float4x4(-27476.0156f, -17606.1328f, 35802.043f, 62706.7773f, -124008.984f, 95400.24f, 26585.3652f, -110297.047f, -156451.781f, -48111.73f, 33951.418f, -2992.24146f, -98858.19f, -43136.55f, 82402.93f, -51477.0977f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x4 a3 = float4x4(-28.9265442f, -326.096161f, 504.3548f, -181.979523f, 312.229553f, 75.6499f, -248.432068f, 507.184265f, 482.400818f, 1.6229248f, -479.952423f, -446.2109f, -414.271545f, -175.72348f, -303.303223f, 70.71069f);
            float4x4 b3 = float4x4(425.693665f, -4.90002441f, -41.369812f, 257.704651f, -456.134979f, -496.704651f, -296.414673f, 156.987183f, 304.616577f, 452.772156f, -124.8772f, -446.8005f, -357.430969f, 217.1565f, 215.616577f, 482.1942f);
            float4x4 r3 = float4x4(-12313.8467f, 1597.87915f, -20865.0625f, -46896.97f, -142418.828f, -37575.66f, 73638.91f, 79621.43f, 146947.281f, 734.8152f, 59935.1133f, 199367.266f, 148073.484f, -38159.4961f, -65397.2031f, 34096.29f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4x4_operator_mul_wide_scalar()
        {
            float4x4 a0 = float4x4(-96.31882f, -277.142273f, -239.93689f, 509.531433f, 255.8581f, 215.7315f, -455.50827f, -389.2433f, -338.29248f, 53.7962646f, 243.757324f, 135.354675f, -207.3501f, -383.9396f, -31.4252319f, 42.6761475f);
            float b0 = (-301.2072f);
            float4x4 r0 = float4x4(29011.9219f, 83477.25f, 72270.72f, -153474.547f, -77066.3047f, -64979.8867f, 137202.375f, 117242.883f, 101896.133f, -16203.8232f, -73421.46f, -40769.8047f, 62455.3438f, 115645.383f, 9465.507f, -12854.3633f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x4 a1 = float4x4(260.38385f, 25.67212f, -290.5006f, 207.091f, -156.523315f, -208.402008f, 370.945068f, -341.59845f, 10.2703247f, -176.888763f, -61.0061035f, 186.279785f, -487.652222f, -129.376831f, -317.7163f, -207.62735f);
            float b1 = (176.867554f);
            float4x4 r1 = float4x4(46053.4531f, 4540.565f, -51380.1328f, 36627.68f, -27683.8965f, -36859.5547f, 65608.15f, -60417.6836f, 1816.48718f, -31285.8828f, -10790f, 32946.85f, -86249.86f, -22882.5645f, -56193.707f, -36722.543f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x4 a2 = float4x4(388.8714f, 128.415527f, 510.389526f, 267.576355f, -309.209656f, -36.48297f, -189.569519f, 233.209229f, -331.086975f, -98.6447754f, -214.181f, -87.88077f, -493.165741f, -407.306061f, -411.3714f, 477.935669f);
            float b2 = (-233.335327f);
            float4x4 r2 = float4x4(-90737.44f, -29963.8789f, -119091.906f, -62435.0156f, 72149.54f, 8512.766f, 44233.2656f, -54415.9531f, 77254.29f, 23017.31f, 49975.9922f, 20505.6875f, 115072.992f, 95038.89f, 95987.48f, -111519.273f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x4 a3 = float4x4(364.748535f, -187.482422f, -287.957642f, 208.590149f, 367.3161f, 443.2597f, -98.88196f, 339.129822f, -266.412231f, -119.37973f, 117.4978f, -63.52304f, -362.640259f, -328.8269f, 49.4736328f, -169.017944f);
            float b3 = (-8.058472f);
            float4x4 r3 = float4x4(-2939.31567f, 1510.82178f, 2320.49854f, -1680.91785f, -2960.00635f, -3571.99585f, 796.837463f, -2732.86816f, 2146.87549f, 962.0182f, -946.8527f, 511.898621f, 2922.32617f, 2649.84229f, -398.681854f, 1362.02637f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4x4_operator_mul_scalar_wide()
        {
            float a0 = (37.43219f);
            float4x4 b0 = float4x4(96.74756f, 492.185364f, -274.054565f, -452.870972f, 420.853333f, 102.182922f, -114.948883f, -351.120056f, -464.664978f, 444.084839f, 447.1053f, 130.829346f, -321.41333f, 445.301331f, 478.2436f, 358.571716f);
            float4x4 r0 = float4x4(3621.473f, 18423.5762f, -10258.4629f, -16951.9531f, 15753.4619f, 3824.93066f, -4302.78857f, -13143.1924f, -17393.4277f, 16623.0684f, 16736.13f, 4897.229f, -12031.2051f, 16668.6035f, 17901.7051f, 13422.125f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (-144.8901f);
            float4x4 b1 = float4x4(-438.893829f, -3.536438f, -471.807556f, -42.5603943f, 119.911072f, 271.900024f, 239.684021f, 487.4414f, -79.18829f, -112.925659f, 161.370056f, 459.759155f, -337.195984f, -276.834534f, 469.723877f, -274.565155f);
            float4x4 r1 = float4x4(63591.375f, 512.3949f, 68360.25f, 6166.58f, -17373.9277f, -39395.625f, -34727.8438f, -70625.44f, 11473.6006f, 16361.8105f, -23380.9238f, -66614.5547f, 48856.3633f, 40110.5859f, -68058.34f, 39781.7734f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (506.7859f);
            float4x4 b2 = float4x4(65.88257f, 495.855652f, -347.2796f, -343.606049f, -183.7038f, 460.264771f, 437.513245f, -324.557251f, -112.287781f, 273.135437f, -283.093658f, 1.880249f, -310.8167f, 326.0122f, 243.64325f, 78.17932f);
            float4x4 r2 = float4x4(33388.3555f, 251292.641f, -175996.4f, -174134.7f, -93098.49f, 233255.688f, 221725.531f, -164481.031f, -56905.8633f, 138421.188f, -143467.875f, 952.883667f, -157517.516f, 165218.391f, 123474.961f, 39620.1758f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-308.664f);
            float4x4 b3 = float4x4(-382.209229f, -134.171875f, -173.004913f, -432.007446f, 488.8365f, -291.7146f, -1.73858643f, -428.3124f, -11.9584045f, -296.891418f, 235.681091f, -298.879181f, 384.531f, 208.919373f, 489.3814f, -106.6055f);
            float4x4 r3 = float4x4(117974.227f, 41414.0273f, 53400.39f, 133345.141f, -150886.219f, 90041.8f, 536.639038f, 132204.625f, 3691.129f, 91639.6953f, -72746.2656f, 92253.24f, -118690.883f, -64485.89f, -151054.422f, 32905.28f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4x4_operator_div_wide_wide()
        {
            float4x4 a0 = float4x4(-353.131439f, -102.799866f, 51.3191528f, -191.871674f, 8.041809f, -128.73764f, -136.0596f, -370.471f, -237.69455f, -432.546875f, 200.2655f, 361.4416f, -416.226135f, -450.0192f, -273.497437f, -286.908173f);
            float4x4 b0 = float4x4(-178.739563f, -302.096283f, -199.405823f, 278.850769f, 502.3376f, -361.484833f, 353.121033f, -38.894928f, -75.76474f, -195.217834f, -405.034f, -394.23f, -375.8277f, -121.245483f, 447.623352f, 338.286255f);
            float4x4 r0 = float4x4(1.97567582f, 0.34028843f, -0.257360339f, -0.688080132f, 0.0160087738f, 0.356135666f, -0.385305852f, 9.524919f, 3.1372714f, 2.215714f, -0.4944412f, -0.9168292f, 1.107492f, 3.71163678f, -0.610999048f, -0.8481225f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x4 a1 = float4x4(-314.256042f, 177.762085f, 97.6270142f, -68.10727f, -386.450745f, 263.699341f, -297.0271f, -501.777039f, -263.40686f, -451.080841f, -416.34552f, -315.278748f, -28.1811218f, -397.870148f, -261.386658f, 40.3482056f);
            float4x4 b1 = float4x4(-405.5442f, -431.168945f, 296.205139f, 437.939819f, 39.2106323f, 331.289734f, -310.619568f, 207.26947f, -223.293f, -480.0914f, 448.675964f, -460.097443f, -220.569855f, -84.85315f, 441.373779f, 72.41846f);
            float4x4 r1 = float4x4(0.7748996f, -0.412279427f, 0.3295926f, -0.155517414f, -9.855764f, 0.795978f, 0.9562408f, -2.42089224f, 1.17964673f, 0.9395729f, -0.9279426f, 0.6852434f, 0.127765059f, 4.688926f, -0.592211545f, 0.557153642f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x4 a2 = float4x4(277.245728f, 464.77124f, -336.641052f, 375.4781f, 504.342529f, -320.7671f, -156.733337f, 414.797058f, -386.0507f, -369.838623f, 386.704224f, 242.631836f, 421.7345f, 109.012207f, 182.075256f, 187.326416f);
            float4x4 b2 = float4x4(44.9760742f, -242.515381f, -451.302063f, -21.8996887f, -358.486664f, -350.945129f, -481.848145f, 406.393433f, -145.288666f, 461.795532f, -318.816772f, -250.932f, 125.859558f, -193.803162f, -495.25412f, -315.824554f);
            float4x4 r2 = float4x4(6.164294f, -1.91646087f, 0.7459329f, -17.14536f, -1.40686548f, 0.9140092f, 0.3252754f, 1.02067852f, 2.65712881f, -0.800870955f, -1.21293569f, -0.966922641f, 3.35083413f, -0.562489331f, -0.367640078f, -0.5931344f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x4 a3 = float4x4(510.862366f, -457.956055f, -263.390778f, 31.9105225f, -86.77109f, -472.43396f, 257.443054f, 208.635864f, -123.366913f, -210.80249f, 299.212463f, 197.7143f, 314.344238f, -152.249908f, -48.31424f, 308.025024f);
            float4x4 b3 = float4x4(-320.719116f, 169.996826f, 252.738342f, -324.1048f, 82.81885f, 454.1411f, -476.333618f, -58.3329773f, -292.26355f, 395.902039f, 90.55267f, 84.0625f, 203.703247f, 49.49939f, 57.28125f, 487.59668f);
            float4x4 r3 = float4x4(-1.59286535f, -2.69390941f, -1.04214811f, -0.09845742f, -1.04772151f, -1.0402801f, -0.540468f, -3.57663655f, 0.422108442f, -0.5324612f, 3.304292f, 2.35199165f, 1.54314792f, -3.07579374f, -0.843456447f, 0.6317209f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4x4_operator_div_wide_scalar()
        {
            float4x4 a0 = float4x4(171.3424f, 0.103393555f, 57.8882446f, -256.130737f, 95.66968f, -290.3869f, -127.4487f, -79.7449f, 146.466858f, -499.843567f, 58.68634f, -453.2058f, -205.033813f, 481.738159f, 464.479065f, -293.4635f);
            float b0 = (171.796814f);
            float4x4 r0 = float4x4(0.997355f, 0.000601836247f, 0.3369576f, -1.49089336f, 0.5568769f, -1.69029272f, -0.7418572f, -0.4641815f, 0.8525586f, -2.90950418f, 0.3416032f, -2.63803387f, -1.1934669f, 2.80411577f, 2.70365357f, -1.708201f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x4 a1 = float4x4(-158.505585f, 494.1286f, 203.583435f, 180.9704f, 259.1192f, 460.844727f, 490.956238f, -280.478058f, -320.243866f, 192.41449f, 264.800842f, 226.852966f, -192.235687f, 460.9765f, -437.8922f, -413.232727f);
            float b1 = (-289.5822f);
            float4x4 r1 = float4x4(0.5473595f, -1.70635f, -0.7030246f, -0.624936163f, -0.8948036f, -1.59141243f, -1.695395f, 0.968561053f, 1.10588241f, -0.6644555f, -0.9144237f, -0.783380151f, 0.663838f, -1.59186745f, 1.5121516f, 1.42699623f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x4 a2 = float4x4(249.471863f, 216.785583f, 383.7389f, 82.0233154f, 189.574646f, 314.503845f, -391.92218f, 121.280579f, 417.901733f, -133.262878f, -428.7424f, -188.531891f, 356.259521f, 181.969f, -140.890472f, 474.082642f);
            float b2 = (313.035034f);
            float4x4 r2 = float4x4(0.7969455f, 0.6925282f, 1.2258656f, 0.262025982f, 0.605602f, 1.0046922f, -1.25200737f, 0.3874345f, 1.33499992f, -0.425712347f, -1.36963069f, -0.6022709f, 1.13808191f, 0.5813055f, -0.450078934f, 1.51447153f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x4 a3 = float4x4(-451.357727f, -220.999786f, 463.01123f, 502.372f, 424.6776f, 51.258667f, 78.93201f, -487.652679f, -96.08646f, 29.1986084f, 119.750427f, 205.4021f, -173.297424f, -448.8201f, -15.4214783f, 472.026917f);
            float b3 = (390.1247f);
            float4x4 r3 = float4x4(-1.15695763f, -0.566485f, 1.18682885f, 1.28772163f, 1.08856893f, 0.131390467f, 0.202325076f, -1.24999177f, -0.246296778f, 0.07484429f, 0.306954235f, 0.5265037f, -0.444210351f, -1.150453f, -0.0395296142f, 1.20993853f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4x4_operator_div_scalar_wide()
        {
            float a0 = (-264.4425f);
            float4x4 b0 = float4x4(105.589111f, -142.349091f, -288.9489f, 39.644104f, -363.9914f, -149.718231f, -395.729126f, 258.7187f, -9.66626f, 117.725525f, -331.386536f, -509.986023f, 427.896484f, 467.617126f, -407.124634f, 252.690735f);
            float4x4 r0 = float4x4(-2.50444865f, 1.85770416f, 0.9151877f, -6.670412f, 0.7265076f, 1.7662679f, 0.6682412f, -1.02212369f, 27.3572731f, -2.246263f, 0.797988057f, 0.518528938f, -0.6180058f, -0.56551075f, 0.649536967f, -1.04650652f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (444.599365f);
            float4x4 b1 = float4x4(-88.31329f, 199.955017f, -218.346924f, -13.4171753f, -296.131073f, 0.561340332f, -289.299316f, 196.218323f, 334.733459f, -282.392731f, -479.5036f, -473.439453f, 105.050781f, -287.6313f, 77.29932f, -210.894379f);
            float4x4 r1 = float4x4(-5.03434229f, 2.223497f, -2.03620625f, -33.1365852f, -1.50136f, 792.031738f, -1.53681445f, 2.26584029f, 1.328219f, -1.5744009f, -0.9272076f, -0.9390839f, 4.232233f, -1.54572678f, 5.75166f, -2.10816121f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (-184.068237f);
            float4x4 b2 = float4x4(-315.148438f, 87.86688f, 101.590515f, 345.9364f, -146.318115f, 479.999939f, -172.67688f, -178.013641f, 361.760437f, 349.376953f, -398.686127f, -243.78f, 296.622925f, 477.810669f, 486.600342f, 256.917236f);
            float4x4 r2 = float4x4(0.584068358f, -2.0948534f, -1.81186438f, -0.5320869f, 1.25800037f, -0.383475542f, 1.06596923f, 1.034012f, -0.5088125f, -0.5268471f, 0.4616871f, 0.7550588f, -0.6205462f, -0.385232568f, -0.378273964f, -0.716449559f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-89.86423f);
            float4x4 b3 = float4x4(-148.205872f, 388.356384f, 76.9372559f, 260.97467f, -110.279846f, 369.089539f, -511.6496f, 355.425781f, -186.724854f, -379.3255f, -428.225525f, 220.158142f, 397.282959f, -106.643188f, 103.314148f, 212.908325f);
            float4x4 r3 = float4x4(0.606347263f, -0.231396288f, -1.16801965f, -0.3443408f, 0.8148744f, -0.2434754f, 0.175636277f, -0.252835423f, 0.4812655f, 0.236905321f, 0.209852576f, -0.408180356f, -0.226197034f, 0.842662632f, -0.8698153f, -0.422079444f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4x4_operator_mod_wide_wide()
        {
            float4x4 a0 = float4x4(-388.8125f, 181.681213f, -167.078735f, 432.820129f, -258.438965f, -170.110809f, 283.3183f, 122.716492f, 335.271f, -503.608521f, 191.022522f, 289.742676f, -124.033722f, 259.274f, -274.358459f, -140.030792f);
            float4x4 b0 = float4x4(436.944153f, 58.9400635f, -201.116241f, 279.289368f, -397.079773f, 377.899963f, 174.693848f, -228.176514f, -317.060181f, -417.4801f, -249.975952f, -397.571564f, -358.745453f, -198.15921f, 208.737122f, -12.1194153f);
            float4x4 r0 = float4x4(-388.8125f, 4.861023f, -167.078735f, 153.530762f, -258.438965f, -170.110809f, 108.624451f, 122.716492f, 18.2108154f, -86.12842f, 191.022522f, 289.742676f, -124.033722f, 61.1147766f, -65.62134f, -6.717224f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x4 a1 = float4x4(324.577576f, -200.513092f, 211.423157f, -51.2722168f, -230.633911f, 99.98938f, 399.18988f, 24.90326f, 50.92401f, -364.863678f, -252.626617f, -281.2898f, -364.798523f, -329.026245f, 51.6098022f, 41.6478271f);
            float4x4 b1 = float4x4(25.2714233f, -194.1207f, -493.8718f, -312.3017f, -216.980591f, 413.570984f, -436.3944f, 3.491272f, -308.233429f, -441.375061f, 84.60083f, 373.163452f, 67.25275f, -320.333282f, 118.97937f, 44.8239746f);
            float4x4 r1 = float4x4(21.3204956f, -6.392395f, 211.423157f, -51.2722168f, -13.65332f, 99.98938f, 399.18988f, 0.464355469f, 50.92401f, -364.863678f, -83.42496f, -281.2898f, -28.53479f, -8.692963f, 51.6098022f, 41.6478271f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x4 a2 = float4x4(254.95105f, -458.6776f, -136.79303f, 72.40033f, 246.212036f, 325.1538f, 162.034668f, -284.761444f, 128.351257f, 262.916748f, 61.60077f, -271.4928f, -205.438812f, -341.322144f, 347.154419f, 148.0885f);
            float4x4 b2 = float4x4(354.0086f, -253.953125f, -195.162811f, 317.142822f, 320.693176f, -103.996887f, 388.171753f, -199.639313f, -256.217316f, -478.125031f, -210.655731f, -272.0233f, -61.6765442f, -367.8296f, -242.938934f, 162.386719f);
            float4x4 r2 = float4x4(254.95105f, -204.724487f, -136.79303f, 72.40033f, 246.212036f, 13.163147f, 162.034668f, -85.12213f, 128.351257f, 262.916748f, 61.60077f, -271.4928f, -20.40918f, -341.322144f, 104.215485f, 148.0885f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x4 a3 = float4x4(253.371582f, -353.380066f, -489.716766f, -371.7157f, 131.366272f, -175.5871f, 271.447021f, -300.871216f, -159.985809f, 63.31543f, 368.062622f, 495.223145f, 113.5014f, 463.485657f, -365.840637f, 481.9884f);
            float4x4 b3 = float4x4(-456.834534f, -466.818756f, -233.143585f, -265.913147f, -170.0065f, -61.3197937f, 334.7071f, -240.970245f, 382.6131f, -204.172882f, 7.772827f, -46.39322f, 325.345642f, 436.883484f, -71.77011f, -22.84903f);
            float4x4 r3 = float4x4(253.371582f, -353.380066f, -23.4295959f, -105.802551f, 131.366272f, -52.94751f, 271.447021f, -59.90097f, -159.985809f, 63.31543f, 2.739746f, 31.2909546f, 113.5014f, 26.6021729f, -6.990082f, 2.158783f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4x4_operator_mod_wide_scalar()
        {
            float4x4 a0 = float4x4(-244.499634f, -211.8193f, -145.926788f, -304.9182f, 155.479492f, -133.907776f, 281.309631f, -226.535767f, 335.166138f, 101.706482f, 319.4715f, -285.4023f, -355.846863f, 259.378f, -330.871948f, -284.343567f);
            float b0 = (39.63495f);
            float4x4 r0 = float4x4(-6.68994141f, -13.6445618f, -27.0219421f, -27.4735718f, 36.574646f, -15.00293f, 3.86499023f, -28.3610229f, 18.0865479f, 22.4365845f, 2.39190674f, -7.957672f, -38.7672729f, 21.5682983f, -13.7923584f, -6.898926f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x4 a1 = float4x4(-102.683441f, 206.41687f, -416.713654f, -339.256653f, 435.2975f, 132.552917f, 226.944092f, -306.1183f, 115.438477f, 281.882935f, -218.347443f, -140.0405f, -462.3235f, -211.6087f, 351.331055f, 321.047f);
            float b1 = (-172.141754f);
            float4x4 r1 = float4x4(-102.683441f, 34.275116f, -72.4301453f, -167.1149f, 91.01398f, 132.552917f, 54.8023376f, -133.976532f, 115.438477f, 109.74118f, -46.20569f, -140.0405f, -118.039978f, -39.46695f, 7.04754639f, 148.905243f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x4 a2 = float4x4(346.0852f, 465.40918f, -367.197021f, -467.5106f, 415.2151f, 506.186157f, -3.729828f, 128.249878f, 134.941589f, 247.616943f, -285.287872f, 433.766663f, -141.831024f, -229.781891f, 471.218018f, 377.681458f);
            float b2 = (-94.4077454f);
            float4x4 r2 = float4x4(62.86197f, 87.7782f, -83.9737854f, -89.87961f, 37.5841064f, 34.14743f, -3.729828f, 33.8421326f, 40.533844f, 58.8014526f, -2.06463623f, 56.13568f, -47.42328f, -40.9664f, 93.5870361f, 0.0504760742f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x4 a3 = float4x4(433.4076f, -333.358124f, 403.178467f, -417.24295f, 116.337463f, 167.627747f, 139.12915f, -510.799957f, -471.958984f, 96.20929f, -12.3428955f, 425.504761f, 285.489624f, -198.684814f, 480.1405f, -94.44934f);
            float b3 = (-99.4491f);
            float4x4 r3 = float4x4(35.6112061f, -35.0108337f, 5.38208f, -19.4465637f, 16.8883667f, 68.17865f, 39.6800537f, -13.5544739f, -74.1626f, 96.20929f, -12.3428955f, 27.708374f, 86.59143f, -99.23572f, 82.34412f, -94.44934f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4x4_operator_mod_scalar_wide()
        {
            float a0 = (-66.94504f);
            float4x4 b0 = float4x4(-249.7761f, -396.073761f, 386.492065f, 168.939453f, -199.418243f, 261.7517f, 16.1274414f, 257.668152f, -75.78845f, 170.9563f, -242.858276f, 425.9453f, 303.2724f, 3.033081f, -505.74353f, 461.957031f);
            float4x4 r0 = float4x4(-66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -2.43527222f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -66.94504f, -0.217254639f, -66.94504f, -66.94504f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (205.972778f);
            float4x4 b1 = float4x4(270.040649f, -47.4807129f, -150.254486f, 149.499512f, -220.298035f, 31.1188354f, 400.635681f, 6.23144531f, -39.05075f, -71.9411f, -495.307129f, -86.7196045f, -436.970062f, -472.294739f, -130.008759f, -251.516846f);
            float4x4 r1 = float4x4(205.972778f, 16.0499268f, 55.7182922f, 56.4732666f, 205.972778f, 19.2597656f, 205.972778f, 0.335083f, 10.7190247f, 62.0905762f, 205.972778f, 32.53357f, 205.972778f, 205.972778f, 75.96402f, 205.972778f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (281.976379f);
            float4x4 b2 = float4x4(388.86084f, 50.6152954f, 293.87085f, 123.744263f, 422.904358f, -53.87619f, -178.857666f, -362.27594f, 361.085266f, 465.276123f, -269.889648f, -159.408966f, -29.0952148f, 484.499451f, -354.950623f, -328.6906f);
            float4x4 r2 = float4x4(281.976379f, 28.8999023f, 281.976379f, 34.487854f, 281.976379f, 12.5954285f, 103.118713f, 281.976379f, 281.976379f, 281.976379f, 12.086731f, 122.567413f, 20.1194458f, 281.976379f, 281.976379f, 281.976379f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-171.739227f);
            float4x4 b3 = float4x4(-300.492981f, -64.58917f, 400.004578f, 295.555481f, 482.521973f, 84.80737f, 497.856384f, -349.291931f, 351.6325f, -178.30719f, -0.5654297f, -167.612244f, -150.81839f, 131.251038f, 399.150452f, 165.462158f);
            float4x4 r3 = float4x4(-171.739227f, -42.5608826f, -171.739227f, -171.739227f, -171.739227f, -2.1244812f, -171.739227f, -171.739227f, -171.739227f, -171.739227f, -0.414031982f, -4.12698364f, -20.9208374f, -40.48819f, -171.739227f, -6.277069f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4x4_operator_plus()
        {
            float4x4 a0 = float4x4(-418.829559f, -405.79895f, -34.04178f, 236.999268f, -459.8391f, 210.86145f, 293.742f, -373.015442f, -386.059845f, 4.95440674f, -418.645264f, 504.474854f, -170.746521f, 439.5594f, -478.7494f, 116.400757f);
            float4x4 r0 = float4x4(-418.829559f, -405.79895f, -34.04178f, 236.999268f, -459.8391f, 210.86145f, 293.742f, -373.015442f, -386.059845f, 4.95440674f, -418.645264f, 504.474854f, -170.746521f, 439.5594f, -478.7494f, 116.400757f);
            TestUtils.AreEqual(+a0, r0);

            float4x4 a1 = float4x4(421.409668f, 447.8661f, 124.164368f, 222.172546f, -65.94928f, 239.041809f, 498.449524f, -139.382538f, 279.072937f, 108.775818f, 37.9992065f, 136.812134f, -236.030029f, -440.308319f, 342.2791f, 102.472229f);
            float4x4 r1 = float4x4(421.409668f, 447.8661f, 124.164368f, 222.172546f, -65.94928f, 239.041809f, 498.449524f, -139.382538f, 279.072937f, 108.775818f, 37.9992065f, 136.812134f, -236.030029f, -440.308319f, 342.2791f, 102.472229f);
            TestUtils.AreEqual(+a1, r1);

            float4x4 a2 = float4x4(-161.454834f, 141.314331f, 239.320862f, -494.6041f, 361.59198f, -14.6017456f, 141.712524f, 25.2562866f, -268.2269f, 106.774658f, 176.744385f, 104.119934f, 144.618591f, 289.4519f, -393.0167f, -198.95575f);
            float4x4 r2 = float4x4(-161.454834f, 141.314331f, 239.320862f, -494.6041f, 361.59198f, -14.6017456f, 141.712524f, 25.2562866f, -268.2269f, 106.774658f, 176.744385f, 104.119934f, 144.618591f, 289.4519f, -393.0167f, -198.95575f);
            TestUtils.AreEqual(+a2, r2);

            float4x4 a3 = float4x4(-419.009216f, 233.295471f, 407.3216f, -129.0021f, 321.17218f, -132.84079f, -20.491333f, -135.618225f, -226.912048f, -409.9144f, -256.257233f, 2.17242432f, 361.9702f, -66.73724f, -248.924377f, -109.997375f);
            float4x4 r3 = float4x4(-419.009216f, 233.295471f, 407.3216f, -129.0021f, 321.17218f, -132.84079f, -20.491333f, -135.618225f, -226.912048f, -409.9144f, -256.257233f, 2.17242432f, 361.9702f, -66.73724f, -248.924377f, -109.997375f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float4x4_operator_neg()
        {
            float4x4 a0 = float4x4(148.461731f, -467.122681f, 132.04718f, 183.522644f, 473.701f, -407.9911f, -54.95877f, -382.9898f, -299.093384f, -383.014069f, 407.709778f, 168.735474f, 466.441528f, 171.902466f, -280.558319f, -78.857605f);
            float4x4 r0 = float4x4(-148.461731f, 467.122681f, -132.04718f, -183.522644f, -473.701f, 407.9911f, 54.95877f, 382.9898f, 299.093384f, 383.014069f, -407.709778f, -168.735474f, -466.441528f, -171.902466f, 280.558319f, 78.857605f);
            TestUtils.AreEqual(-a0, r0);

            float4x4 a1 = float4x4(318.69635f, 140.340027f, 132.195618f, -505.895264f, 410.380554f, -237.056946f, -137.617828f, -245.349976f, 422.521362f, -434.57135f, 60.22223f, -466.5663f, 426.894531f, 146.649536f, -391.37207f, 423.237732f);
            float4x4 r1 = float4x4(-318.69635f, -140.340027f, -132.195618f, 505.895264f, -410.380554f, 237.056946f, 137.617828f, 245.349976f, -422.521362f, 434.57135f, -60.22223f, 466.5663f, -426.894531f, -146.649536f, 391.37207f, -423.237732f);
            TestUtils.AreEqual(-a1, r1);

            float4x4 a2 = float4x4(254.297546f, 108.059692f, -507.9763f, -306.245728f, 219.66626f, 474.667969f, -98.76068f, 492.111084f, 84.04584f, 300.976624f, -483.864624f, -389.15744f, -324.6861f, 378.85437f, 190.219238f, -69.10242f);
            float4x4 r2 = float4x4(-254.297546f, -108.059692f, 507.9763f, 306.245728f, -219.66626f, -474.667969f, 98.76068f, -492.111084f, -84.04584f, -300.976624f, 483.864624f, 389.15744f, 324.6861f, -378.85437f, -190.219238f, 69.10242f);
            TestUtils.AreEqual(-a2, r2);

            float4x4 a3 = float4x4(507.495361f, 245.013367f, 429.615784f, 142.357f, -430.84906f, 281.934265f, -242.334961f, -83.12738f, -460.8203f, -485.419739f, 396.819031f, -428.4235f, -213.987885f, -17.6636353f, 287.0819f, 257.497742f);
            float4x4 r3 = float4x4(-507.495361f, -245.013367f, -429.615784f, -142.357f, 430.84906f, -281.934265f, 242.334961f, 83.12738f, 460.8203f, 485.419739f, -396.819031f, 428.4235f, 213.987885f, 17.6636353f, -287.0819f, -257.497742f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float4x4_operator_prefix_inc()
        {
            float4x4 a0 = float4x4(-139.842072f, -56.7436523f, -381.955322f, 509.796326f, -222.896332f, 210.319885f, -392.7315f, -300.1941f, 362.212769f, 401.6148f, 130.90918f, -450.230164f, 243.546936f, 46.1920166f, -41.4972839f, 299.1855f);
            float4x4 r0 = float4x4(-138.842072f, -55.7436523f, -380.955322f, 510.796326f, -221.896332f, 211.319885f, -391.7315f, -299.1941f, 363.212769f, 402.6148f, 131.90918f, -449.230164f, 244.546936f, 47.1920166f, -40.4972839f, 300.1855f);
            TestUtils.AreEqual(++a0, r0);

            float4x4 a1 = float4x4(154.356567f, 200.706f, 92.95776f, 448.602173f, -295.587f, 18.4990845f, -215.711121f, 471.947266f, 257.0766f, 41.6259155f, 4.82543945f, 243.004761f, -472.619019f, -125.720215f, -477.459564f, 9.89147949f);
            float4x4 r1 = float4x4(155.356567f, 201.706f, 93.95776f, 449.602173f, -294.587f, 19.4990845f, -214.711121f, 472.947266f, 258.0766f, 42.6259155f, 5.82543945f, 244.004761f, -471.619019f, -124.720215f, -476.459564f, 10.8914795f);
            TestUtils.AreEqual(++a1, r1);

            float4x4 a2 = float4x4(-76.92285f, -387.177429f, 461.7093f, 13.699707f, -46.303772f, 89.36603f, -222.2291f, 340.8178f, 399.741272f, -311.372345f, 300.177979f, -272.7783f, 351.019165f, 436.575256f, -137.063324f, 312.579956f);
            float4x4 r2 = float4x4(-75.92285f, -386.177429f, 462.7093f, 14.699707f, -45.303772f, 90.36603f, -221.2291f, 341.8178f, 400.741272f, -310.372345f, 301.177979f, -271.7783f, 352.019165f, 437.575256f, -136.063324f, 313.579956f);
            TestUtils.AreEqual(++a2, r2);

            float4x4 a3 = float4x4(-315.999023f, -442.44696f, -93.81058f, -76.4442444f, -8.3284f, 436.757263f, 345.7558f, -474.150879f, 32.02704f, -343.3061f, 114.443054f, -31.1988831f, 322.8318f, 15.335022f, 96.3687744f, 51.8783569f);
            float4x4 r3 = float4x4(-314.999023f, -441.44696f, -92.81058f, -75.4442444f, -7.32839966f, 437.757263f, 346.7558f, -473.150879f, 33.02704f, -342.3061f, 115.443054f, -30.1988831f, 323.8318f, 16.335022f, 97.3687744f, 52.8783569f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float4x4_operator_postfix_inc()
        {
            float4x4 a0 = float4x4(-396.669739f, 511.20752f, 249.111267f, -128.817322f, -259.4903f, 278.008179f, -81.39343f, 66.71973f, 167.852112f, 147.94397f, -326.1076f, 41.03357f, 128.5304f, 73.15558f, -60.1323853f, -446.229767f);
            float4x4 r0 = float4x4(-396.669739f, 511.20752f, 249.111267f, -128.817322f, -259.4903f, 278.008179f, -81.39343f, 66.71973f, 167.852112f, 147.94397f, -326.1076f, 41.03357f, 128.5304f, 73.15558f, -60.1323853f, -446.229767f);
            TestUtils.AreEqual(a0++, r0);

            float4x4 a1 = float4x4(-296.937836f, 446.2293f, 49.2001953f, -326.643127f, -510.864227f, 471.647461f, -171.013092f, 310.727356f, -298.917175f, 489.985f, 184.603455f, 290.69104f, 117.192322f, 164.442932f, 412.3678f, -229.386566f);
            float4x4 r1 = float4x4(-296.937836f, 446.2293f, 49.2001953f, -326.643127f, -510.864227f, 471.647461f, -171.013092f, 310.727356f, -298.917175f, 489.985f, 184.603455f, 290.69104f, 117.192322f, 164.442932f, 412.3678f, -229.386566f);
            TestUtils.AreEqual(a1++, r1);

            float4x4 a2 = float4x4(239.596924f, -80.70819f, -391.0335f, -478.227142f, 166.860474f, -291.1745f, -389.396667f, -52.13214f, 35.75531f, 356.052124f, 6.52948f, -285.349823f, 418.016479f, 47.1428833f, 31.4516f, 148.9469f);
            float4x4 r2 = float4x4(239.596924f, -80.70819f, -391.0335f, -478.227142f, 166.860474f, -291.1745f, -389.396667f, -52.13214f, 35.75531f, 356.052124f, 6.52948f, -285.349823f, 418.016479f, 47.1428833f, 31.4516f, 148.9469f);
            TestUtils.AreEqual(a2++, r2);

            float4x4 a3 = float4x4(-219.800385f, 448.954224f, -32.54605f, 441.9734f, -128.249451f, -472.44f, -91.87564f, 72.45532f, -472.57312f, 300.0232f, 246.003113f, 288.0287f, -461.3402f, 495.501038f, -226.475372f, -241.579865f);
            float4x4 r3 = float4x4(-219.800385f, 448.954224f, -32.54605f, 441.9734f, -128.249451f, -472.44f, -91.87564f, 72.45532f, -472.57312f, 300.0232f, 246.003113f, 288.0287f, -461.3402f, 495.501038f, -226.475372f, -241.579865f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float4x4_operator_prefix_dec()
        {
            float4x4 a0 = float4x4(123.128723f, 256.84375f, 156.330811f, 461.737427f, 325.867981f, 392.015625f, 187.874146f, -236.225189f, 125.109619f, 469.844727f, 45.5366821f, 376.046875f, -363.0755f, -22.0289612f, 248.7901f, 168.095032f);
            float4x4 r0 = float4x4(122.128723f, 255.84375f, 155.330811f, 460.737427f, 324.867981f, 391.015625f, 186.874146f, -237.225189f, 124.109619f, 468.844727f, 44.5366821f, 375.046875f, -364.0755f, -23.0289612f, 247.7901f, 167.095032f);
            TestUtils.AreEqual(--a0, r0);

            float4x4 a1 = float4x4(168.265625f, 166.945557f, 183.957947f, 485.6947f, -460.739319f, 89.5698853f, -267.4298f, 201.756226f, -141.216888f, -217.4841f, 197.361755f, -213.544128f, 180.7406f, -128.3125f, 478.045532f, -454.566132f);
            float4x4 r1 = float4x4(167.265625f, 165.945557f, 182.957947f, 484.6947f, -461.739319f, 88.5698853f, -268.4298f, 200.756226f, -142.216888f, -218.4841f, 196.361755f, -214.544128f, 179.7406f, -129.3125f, 477.045532f, -455.566132f);
            TestUtils.AreEqual(--a1, r1);

            float4x4 a2 = float4x4(-386.898346f, -315.110443f, -108.28656f, -286.317017f, -375.601563f, -87.60596f, 78.27545f, 161.531982f, -346.847961f, -57.54077f, 455.372864f, 444.798157f, 129.820129f, 134.710632f, 61.322998f, -274.543335f);
            float4x4 r2 = float4x4(-387.898346f, -316.110443f, -109.28656f, -287.317017f, -376.601563f, -88.60596f, 77.27545f, 160.531982f, -347.847961f, -58.54077f, 454.372864f, 443.798157f, 128.820129f, 133.710632f, 60.322998f, -275.543335f);
            TestUtils.AreEqual(--a2, r2);

            float4x4 a3 = float4x4(-43.39557f, 211.510681f, -161.216339f, 149.434021f, 90.4324951f, -344.726135f, -88.23938f, -252.0188f, -44.91513f, 97.4996948f, 502.5124f, 489.3189f, 456.369019f, 86.15723f, 79.49109f, 318.612976f);
            float4x4 r3 = float4x4(-44.39557f, 210.510681f, -162.216339f, 148.434021f, 89.4324951f, -345.726135f, -89.23938f, -253.0188f, -45.91513f, 96.4996948f, 501.5124f, 488.3189f, 455.369019f, 85.15723f, 78.49109f, 317.612976f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float4x4_operator_postfix_dec()
        {
            float4x4 a0 = float4x4(379.6883f, 302.692871f, -176.07135f, -291.2527f, 470.567566f, -402.925964f, -63.65515f, 355.2611f, -27.8892212f, -100.761841f, 156.14032f, 479.9452f, -200.304291f, -445.026947f, 407.420349f, 327.670349f);
            float4x4 r0 = float4x4(379.6883f, 302.692871f, -176.07135f, -291.2527f, 470.567566f, -402.925964f, -63.65515f, 355.2611f, -27.8892212f, -100.761841f, 156.14032f, 479.9452f, -200.304291f, -445.026947f, 407.420349f, 327.670349f);
            TestUtils.AreEqual(a0--, r0);

            float4x4 a1 = float4x4(48.06018f, -38.43506f, 283.9416f, -94.80209f, 152.510681f, -287.2625f, -215.948029f, -407.046356f, 159.233582f, -359.456482f, 168.41394f, -278.933777f, 289.912842f, 402.039551f, 470.716553f, -208.560608f);
            float4x4 r1 = float4x4(48.06018f, -38.43506f, 283.9416f, -94.80209f, 152.510681f, -287.2625f, -215.948029f, -407.046356f, 159.233582f, -359.456482f, 168.41394f, -278.933777f, 289.912842f, 402.039551f, 470.716553f, -208.560608f);
            TestUtils.AreEqual(a1--, r1);

            float4x4 a2 = float4x4(145.896729f, -274.570831f, -250.04126f, -70.85629f, -485.627838f, -341.094543f, -503.192078f, 397.648621f, 446.621582f, -292.81012f, 126.6225f, -250.442413f, 470.816467f, 26.9436035f, -186.923523f, 45.7460938f);
            float4x4 r2 = float4x4(145.896729f, -274.570831f, -250.04126f, -70.85629f, -485.627838f, -341.094543f, -503.192078f, 397.648621f, 446.621582f, -292.81012f, 126.6225f, -250.442413f, 470.816467f, 26.9436035f, -186.923523f, 45.7460938f);
            TestUtils.AreEqual(a2--, r2);

            float4x4 a3 = float4x4(-206.455963f, -350.94812f, -92.1842041f, -37.5095825f, 114.516663f, 77.95538f, -472.1233f, -396.2063f, -200.665985f, 468.530518f, 279.9309f, 122.194885f, 194.197937f, 9.198608f, 197.423828f, 176.5058f);
            float4x4 r3 = float4x4(-206.455963f, -350.94812f, -92.1842041f, -37.5095825f, 114.516663f, 77.95538f, -472.1233f, -396.2063f, -200.665985f, 468.530518f, 279.9309f, 122.194885f, 194.197937f, 9.198608f, 197.423828f, 176.5058f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
