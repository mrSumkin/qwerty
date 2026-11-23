using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000374 RID: 884
public static class eth
{
	// Token: 0x06001892 RID: 6290 RVA: 0x0007E818 File Offset: 0x0007CA18
	public static bool m(bm6 A_0)
	{
		List<string> classPropertyValue = A_0.y6().GetClassPropertyValue<List<string>>(ddq.k);
		return classPropertyValue != null && classPropertyValue.Count > 0;
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x0007E848 File Offset: 0x0007CA48
	public static ak1 l(bm6 A_0)
	{
		int? primitivePropertyValue = A_0.y6().GetPrimitivePropertyValue<int>(ddq.j, null);
		List<string> classPropertyValue = A_0.y6().GetClassPropertyValue<List<string>>(ddq.k);
		if (primitivePropertyValue != null && classPropertyValue != null && primitivePropertyValue.Value < classPropertyValue.Count)
		{
			aud aud;
			Vector3 vector;
			HorizontalDirection horizontalDirection;
			new bt4(classPropertyValue[primitivePropertyValue.Value]).a(A_0.a8().Zone, out aud, out vector, out horizontalDirection);
			if (aud != null)
			{
				return aud.a(new Point((int)vector.X, (int)vector.Y));
			}
		}
		return null;
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x0007E8F0 File Offset: 0x0007CAF0
	public static void k(bm6 A_0)
	{
		List<string> classPropertyValue = A_0.y6().GetClassPropertyValue<List<string>>(ddq.k);
		int? num = A_0.y6().GetPrimitivePropertyValue<int>(ddq.j, null);
		if (classPropertyValue != null && classPropertyValue.Count > 0)
		{
			if (num == null)
			{
				num = new int?(0);
			}
			else
			{
				num++;
				int? num2 = num;
				int count = classPropertyValue.Count;
				if (num2.GetValueOrDefault() >= count & num2 != null)
				{
					num = new int?(0);
				}
			}
			A_0.y6()[ddq.j] = num.Value;
		}
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x0007E9C8 File Offset: 0x0007CBC8
	public static bool j(bm6 A_0)
	{
		return A_0.y6().GetClassPropertyValue<bt4>(ddq.ai) != null;
	}

	// Token: 0x06001896 RID: 6294 RVA: 0x0007E9E0 File Offset: 0x0007CBE0
	public static ak1 i(bm6 A_0)
	{
		bt4 classPropertyValue = A_0.y6().GetClassPropertyValue<bt4>(ddq.ai);
		if (classPropertyValue != null)
		{
			aud aud;
			Vector3 vector;
			HorizontalDirection horizontalDirection;
			classPropertyValue.a(A_0.a8().Zone, out aud, out vector, out horizontalDirection);
			if (aud != null)
			{
				return aud.a(new Point((int)vector.X, (int)vector.Y));
			}
		}
		return null;
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x0007EA3C File Offset: 0x0007CC3C
	public static void h(bm6 A_0)
	{
		A_0.y6().RemoveProperty(ddq.ai);
	}

	// Token: 0x06001898 RID: 6296 RVA: 0x0007EA50 File Offset: 0x0007CC50
	public static ak1 g(bm6 A_0)
	{
		bt4 classPropertyValue = A_0.y6().GetClassPropertyValue<bt4>(ddq.am);
		if (classPropertyValue != null)
		{
			return eth.a(classPropertyValue, A_0.a8().Zone);
		}
		return null;
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x0007EA88 File Offset: 0x0007CC88
	public static ak1 f(bm6 A_0)
	{
		bt4 classPropertyValue = A_0.y6().GetClassPropertyValue<bt4>(ddq.an);
		if (classPropertyValue != null)
		{
			return eth.a(classPropertyValue, A_0.a8().Zone);
		}
		return null;
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x0007EAC0 File Offset: 0x0007CCC0
	public static void e(bm6 A_0)
	{
		A_0.y6().RemoveProperty(ddq.am);
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x0007EAD8 File Offset: 0x0007CCD8
	public static bool d(bm6 A_0)
	{
		if (A_0 != null && A_0.a8() != null && A_0.a8().Area != null)
		{
			bt4 classPropertyValue = A_0.y6().GetClassPropertyValue<bt4>("GuardLoc");
			if (classPropertyValue != null)
			{
				aud aud;
				Vector3 value;
				HorizontalDirection horizontalDirection;
				classPropertyValue.a(A_0.a8().Zone, out aud, out value, out horizontalDirection);
				return aud == A_0.a8().Area && A_0.a8().Location == value && A_0.a8().VisualDirection == horizontalDirection;
			}
		}
		return false;
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x0007EB70 File Offset: 0x0007CD70
	public static bool c(bm6 A_0)
	{
		return A_0 != null && A_0.a8() != null && A_0.a8().Area != null && A_0.y6().GetClassPropertyValue<bt4>("GuardLoc") != null;
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x0007EBB4 File Offset: 0x0007CDB4
	public static string b(bm6 A_0)
	{
		int? primitivePropertyValue = A_0.y6().GetPrimitivePropertyValue<int>(ddq.j, null);
		List<string> classPropertyValue = A_0.y6().GetClassPropertyValue<List<string>>(ddq.k);
		if (primitivePropertyValue != null && classPropertyValue != null && classPropertyValue.Count > 0)
		{
			int num = primitivePropertyValue.Value - 1;
			if (num < 0)
			{
				num = classPropertyValue.Count - 1;
			}
			if (num < classPropertyValue.Count && num >= 0)
			{
				return classPropertyValue[num];
			}
		}
		return null;
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x0007EC40 File Offset: 0x0007CE40
	public static bool a(bm6 A_0)
	{
		if (A_0.y6().GetPrimitivePropertyValue<bool>(ddq.av, new bool?(false)).Value)
		{
			if (eth.d(A_0))
			{
				return true;
			}
			if (eth.m(A_0))
			{
				int? primitivePropertyValue = A_0.y6().GetPrimitivePropertyValue<int>(ddq.l, null);
				if (primitivePropertyValue != null)
				{
					TimeSpan? primitivePropertyValue2 = A_0.y6().GetPrimitivePropertyValue<TimeSpan>(ddq.m, null);
					if (primitivePropertyValue2 != null)
					{
						TimeSpan t = A_0.a8().Zone.ElapsedZoneTime;
						return t >= primitivePropertyValue2 - TimeSpan.FromMilliseconds((double)primitivePropertyValue.Value - 50.0);
					}
					if (bpo.GetServiceOrThrow<d02>().ahg() && A_0.a8().l.Contains(A_0.a8().Zone.g(eth.b(A_0)).Tile))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x0007ED94 File Offset: 0x0007CF94
	private static ak1 a(bt4 A_0, c1a A_1)
	{
		aud aud;
		Vector3 vector;
		HorizontalDirection horizontalDirection;
		A_0.a(A_1, out aud, out vector, out horizontalDirection);
		if (aud != null)
		{
			return aud.a(new Point((int)vector.X, (int)vector.Y));
		}
		return null;
	}
}
