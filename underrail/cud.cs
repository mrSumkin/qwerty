using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

// Token: 0x020004BA RID: 1210
public static class cud
{
	// Token: 0x06001EF1 RID: 7921 RVA: 0x000AB578 File Offset: 0x000A9778
	static cud()
	{
		for (int i = 0; i < 512; i++)
		{
			cud.c[i] = cud.b[i % 256];
		}
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x000AB5D8 File Offset: 0x000A97D8
	private static void a(uint A_0)
	{
		cud.a a = new cud.a();
		a.a = A_0;
		cud.b = Enumerable.ToArray<int>(Enumerable.OrderBy<int, uint>(Enumerable.Range(0, cud.b.Length), new Func<int, uint>(a.a)));
	}

	// Token: 0x06001EF3 RID: 7923 RVA: 0x000AB61C File Offset: 0x000A981C
	public static float a(float A_0, float A_1, float A_2, int A_3 = 0, int A_4 = 0)
	{
		if (A_4 > 0)
		{
			cud.a = A_4;
			A_0 %= (float)A_4;
			A_1 %= (float)A_4;
			A_2 %= (float)A_4;
		}
		int num = (int)A_0 & 255;
		int num2 = (int)A_1 & 255;
		int num3 = (int)A_2 & 255;
		float num4 = A_0 - (float)((int)A_0);
		float num5 = A_1 - (float)((int)A_1);
		float num6 = A_2 - (float)((int)A_2);
		float a_ = cud.a(num4);
		float a_2 = cud.a(num5);
		float a_3 = cud.a(num6);
		int a_4 = (int)cud.a((byte)cud.c[cud.c[cud.c[num] + num2] + num3], A_3);
		int a_5 = (int)cud.a((byte)cud.c[cud.c[cud.c[num] + cud.a(num2)] + num3], A_3);
		int a_6 = (int)cud.a((byte)cud.c[cud.c[cud.c[num] + num2] + cud.a(num3)], A_3);
		int a_7 = (int)cud.a((byte)cud.c[cud.c[cud.c[num] + cud.a(num2)] + cud.a(num3)], A_3);
		int a_8 = (int)cud.a((byte)cud.c[cud.c[cud.c[cud.a(num)] + num2] + num3], A_3);
		int a_9 = (int)cud.a((byte)cud.c[cud.c[cud.c[cud.a(num)] + cud.a(num2)] + num3], A_3);
		int a_10 = (int)cud.a((byte)cud.c[cud.c[cud.c[cud.a(num)] + num2] + cud.a(num3)], A_3);
		int a_11 = (int)cud.a((byte)cud.c[cud.c[cud.c[cud.a(num)] + cud.a(num2)] + cud.a(num3)], A_3);
		float a_12 = cud.a(cud.a(a_4, num4, num5, num6), cud.a(a_8, num4 - 1f, num5, num6), a_);
		float a_13 = cud.a(cud.a(a_5, num4, num5 - 1f, num6), cud.a(a_9, num4 - 1f, num5 - 1f, num6), a_);
		float a_14 = cud.a(a_12, a_13, a_2);
		float a_15 = cud.a(cud.a(a_6, num4, num5, num6 - 1f), cud.a(a_10, num4 - 1f, num5, num6 - 1f), a_);
		a_13 = cud.a(cud.a(a_7, num4, num5 - 1f, num6 - 1f), cud.a(a_11, num4 - 1f, num5 - 1f, num6 - 1f), a_);
		float a_16 = cud.a(a_15, a_13, a_2);
		return cud.a(a_14, a_16, a_3);
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x000AB8B4 File Offset: 0x000A9AB4
	public static float a(Vector3 A_0, int A_1 = 0, int A_2 = 0)
	{
		float num = A_0.X;
		float num2 = A_0.Y;
		float num3 = A_0.Z;
		if (A_2 > 0)
		{
			cud.a = A_2;
			num %= (float)A_2;
			num2 %= (float)A_2;
			num3 %= (float)A_2;
		}
		int num4 = (int)num & 255;
		int num5 = (int)num2 & 255;
		int num6 = (int)num3 & 255;
		float num7 = num - (float)((int)num);
		float num8 = num2 - (float)((int)num2);
		float num9 = num3 - (float)((int)num3);
		float a_ = cud.a(num7);
		float a_2 = cud.a(num8);
		float a_3 = cud.a(num9);
		int a_4 = (int)cud.a((byte)cud.c[cud.c[cud.c[num4] + num5] + num6], A_1);
		int a_5 = (int)cud.a((byte)cud.c[cud.c[cud.c[num4] + cud.a(num5)] + num6], A_1);
		int a_6 = (int)cud.a((byte)cud.c[cud.c[cud.c[num4] + num5] + cud.a(num6)], A_1);
		int a_7 = (int)cud.a((byte)cud.c[cud.c[cud.c[num4] + cud.a(num5)] + cud.a(num6)], A_1);
		int a_8 = (int)cud.a((byte)cud.c[cud.c[cud.c[cud.a(num4)] + num5] + num6], A_1);
		int a_9 = (int)cud.a((byte)cud.c[cud.c[cud.c[cud.a(num4)] + cud.a(num5)] + num6], A_1);
		int a_10 = (int)cud.a((byte)cud.c[cud.c[cud.c[cud.a(num4)] + num5] + cud.a(num6)], A_1);
		int a_11 = (int)cud.a((byte)cud.c[cud.c[cud.c[cud.a(num4)] + cud.a(num5)] + cud.a(num6)], A_1);
		float a_12 = cud.a(cud.a(a_4, num7, num8, num9), cud.a(a_8, num7 - 1f, num8, num9), a_);
		float a_13 = cud.a(cud.a(a_5, num7, num8 - 1f, num9), cud.a(a_9, num7 - 1f, num8 - 1f, num9), a_);
		float a_14 = cud.a(a_12, a_13, a_2);
		float a_15 = cud.a(cud.a(a_6, num7, num8, num9 - 1f), cud.a(a_10, num7 - 1f, num8, num9 - 1f), a_);
		a_13 = cud.a(cud.a(a_7, num7, num8 - 1f, num9 - 1f), cud.a(a_11, num7 - 1f, num8 - 1f, num9 - 1f), a_);
		float a_16 = cud.a(a_15, a_13, a_2);
		return cud.a(a_14, a_16, a_3);
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x000ABB74 File Offset: 0x000A9D74
	private static float a(float A_0, float A_1, float A_2)
	{
		return A_0 + A_2 * (A_1 - A_0);
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x000ABB80 File Offset: 0x000A9D80
	private static float a(int A_0, float A_1, float A_2, float A_3)
	{
		switch (A_0 & 15)
		{
		case 0:
			return A_1 + A_2;
		case 1:
			return -A_1 + A_2;
		case 2:
			return A_1 - A_2;
		case 3:
			return -A_1 - A_2;
		case 4:
			return A_1 + A_3;
		case 5:
			return -A_1 + A_3;
		case 6:
			return A_1 - A_3;
		case 7:
			return -A_1 - A_3;
		case 8:
			return A_2 + A_3;
		case 9:
			return -A_2 + A_3;
		case 10:
			return A_2 - A_3;
		case 11:
			return -A_2 - A_3;
		case 12:
			return A_2 + A_1;
		case 13:
			return -A_2 + A_3;
		case 14:
			return A_2 - A_1;
		case 15:
			return -A_2 - A_3;
		default:
			return 0f;
		}
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x000ABC2C File Offset: 0x000A9E2C
	private static uint a(int A_0, uint A_1)
	{
		int num = (A_0 >= 0) ? A_0 : (A_0 * -1);
		int num2 = num ^ num << 13;
		int num3 = num2 ^ (int)((uint)num2 >> 17);
		uint num4 = (uint)(num3 ^ num3 << 5);
		A_1 ^= 362436069U;
		return num4 ^ A_1;
	}

	// Token: 0x06001EF8 RID: 7928 RVA: 0x000ABC5C File Offset: 0x000A9E5C
	private static byte a(byte A_0, int A_1)
	{
		A_1 ^= 68;
		byte b = A_0 ^ (byte)(A_0 << 7);
		b ^= (byte)A_1;
		b ^= (byte)(b >> 12);
		return b ^ (byte)(b << 3);
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x000ABC94 File Offset: 0x000A9E94
	private static int a(int A_0)
	{
		A_0++;
		if (cud.a > 0)
		{
			A_0 %= cud.a;
		}
		return A_0;
	}

	// Token: 0x06001EFA RID: 7930 RVA: 0x000ABCB0 File Offset: 0x000A9EB0
	private static float a(float A_0)
	{
		return A_0 * A_0 * A_0 * (A_0 * (A_0 * 6f - 15f) + 10f);
	}

	// Token: 0x040013A1 RID: 5025
	public static int a;

	// Token: 0x040013A2 RID: 5026
	private static int[] b = new int[]
	{
		151,
		160,
		137,
		91,
		90,
		15,
		131,
		13,
		201,
		95,
		96,
		53,
		194,
		233,
		7,
		225,
		140,
		36,
		103,
		30,
		69,
		142,
		8,
		99,
		37,
		240,
		21,
		10,
		23,
		190,
		6,
		148,
		247,
		120,
		234,
		75,
		0,
		26,
		197,
		62,
		94,
		252,
		219,
		203,
		117,
		35,
		11,
		32,
		57,
		177,
		33,
		88,
		237,
		149,
		56,
		87,
		174,
		20,
		125,
		136,
		171,
		168,
		68,
		175,
		74,
		165,
		71,
		134,
		139,
		48,
		27,
		166,
		77,
		146,
		158,
		231,
		83,
		111,
		229,
		122,
		60,
		211,
		133,
		230,
		220,
		105,
		92,
		41,
		55,
		46,
		245,
		40,
		244,
		102,
		143,
		54,
		65,
		25,
		63,
		161,
		1,
		216,
		80,
		84,
		209,
		76,
		132,
		187,
		208,
		89,
		18,
		169,
		200,
		196,
		135,
		130,
		116,
		188,
		159,
		86,
		164,
		100,
		109,
		198,
		173,
		186,
		3,
		64,
		52,
		217,
		226,
		250,
		124,
		123,
		5,
		202,
		38,
		147,
		118,
		126,
		255,
		82,
		85,
		212,
		207,
		206,
		59,
		227,
		47,
		16,
		58,
		17,
		182,
		189,
		28,
		42,
		223,
		183,
		170,
		213,
		119,
		248,
		152,
		2,
		44,
		154,
		163,
		70,
		221,
		153,
		101,
		155,
		167,
		43,
		172,
		9,
		129,
		22,
		39,
		253,
		19,
		98,
		108,
		110,
		79,
		113,
		224,
		232,
		178,
		185,
		112,
		104,
		218,
		246,
		97,
		228,
		251,
		34,
		242,
		193,
		238,
		210,
		144,
		12,
		191,
		179,
		162,
		241,
		81,
		51,
		145,
		235,
		249,
		14,
		239,
		107,
		49,
		192,
		214,
		31,
		181,
		199,
		106,
		157,
		184,
		73,
		204,
		176,
		115,
		121,
		50,
		45,
		127,
		4,
		150,
		254,
		138,
		236,
		205,
		93,
		222,
		114,
		67,
		29,
		24,
		72,
		243,
		141,
		128,
		195,
		78,
		66,
		215,
		61,
		156,
		180
	};

	// Token: 0x040013A3 RID: 5027
	private static int[] c = new int[512];

	// Token: 0x020004BB RID: 1211
	[CompilerGenerated]
	private sealed class a
	{
		// Token: 0x06001EFC RID: 7932 RVA: 0x000ABCD8 File Offset: 0x000A9ED8
		internal uint a(int A_0)
		{
			return cud.a(A_0, this.a);
		}

		// Token: 0x040013A4 RID: 5028
		public uint a;
	}
}
