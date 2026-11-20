using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

// Token: 0x02001182 RID: 4482
public static class aur
{
	// Token: 0x06005FB3 RID: 24499 RVA: 0x0029B1F4 File Offset: 0x002993F4
	public static a3f d(this c5x A_0)
	{
		if (A_0 != null)
		{
			a3f a3f = A_0.GetAspect<a3f>();
			if (a3f == null)
			{
				a3f = new a3f(A_0);
				A_0.SetAspect<a3f>(a3f);
			}
			return a3f;
		}
		return null;
	}

	// Token: 0x06005FB4 RID: 24500 RVA: 0x0029B228 File Offset: 0x00299428
	public static aru c(this c5x A_0)
	{
		if (A_0 != null)
		{
			aru aru;
			if (A_0.v != null)
			{
				aru = A_0.v.b;
			}
			else
			{
				aru = A_0.GetAspect<aru>();
			}
			if (aru == null)
			{
				aru = new aru(A_0);
				A_0.SetAspect<aru>(aru);
			}
			return aru;
		}
		return null;
	}

	// Token: 0x06005FB5 RID: 24501 RVA: 0x0029B278 File Offset: 0x00299478
	public static void b(this c5x A_0, string A_1)
	{
		if (A_0 != null)
		{
			e3l e3l = A_0.GetAspect<e3l>();
			if (e3l == null)
			{
				e3l = new e3l(A_0);
				A_0.SetAspect<e3l>(e3l);
			}
			if (!e3l.a.Contains(A_1))
			{
				e3l.a.Add(A_1);
				e3l.a();
			}
		}
	}

	// Token: 0x06005FB6 RID: 24502 RVA: 0x0029B2CC File Offset: 0x002994CC
	public static List<string> b(this c5x A_0)
	{
		List<string> list = new List<string>();
		if (A_0 != null)
		{
			e3l aspect = A_0.GetAspect<e3l>();
			if (aspect != null)
			{
				foreach (string text in aspect.a)
				{
					if (!string.IsNullOrEmpty(text))
					{
						list.Add(text);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06005FB7 RID: 24503 RVA: 0x0029B34C File Offset: 0x0029954C
	public static bool a(this c5x A_0, string A_1)
	{
		if (A_0 != null)
		{
			e3l aspect = A_0.GetAspect<e3l>();
			return aspect != null && aspect.a.Contains(A_1);
		}
		return false;
	}

	// Token: 0x06005FB8 RID: 24504 RVA: 0x0029B37C File Offset: 0x0029957C
	public static bool a(this c5x A_0)
	{
		if (A_0 != null)
		{
			dt5 aspect = A_0.GetAspect<dt5>();
			return aspect == null || (aspect.e() != null && aspect.e().Value);
		}
		return true;
	}

	// Token: 0x06005FB9 RID: 24505 RVA: 0x0029B3C4 File Offset: 0x002995C4
	public static c0s a(this c5x A_0, dsu? A_1 = null)
	{
		if (A_0 != null)
		{
			c0s c0s = A_0.u.b;
			if (c0s == null)
			{
				c0s = new c0s(A_0);
				if (A_1 != null)
				{
					c0s.a(A_1.Value);
				}
				A_0.SetAspect<c0s>(c0s);
			}
			return c0s;
		}
		return null;
	}

	// Token: 0x06005FBA RID: 24506 RVA: 0x0029B414 File Offset: 0x00299614
	public static d60 a(this c1a A_0)
	{
		if (A_0 != null)
		{
			return A_0.GetAddon<d60>();
		}
		return null;
	}

	// Token: 0x06005FBB RID: 24507 RVA: 0x0029B424 File Offset: 0x00299624
	public static d60 a(this b0b A_0)
	{
		if (A_0 != null)
		{
			return A_0.Zone.a();
		}
		return null;
	}

	// Token: 0x06005FBC RID: 24508 RVA: 0x0029B43C File Offset: 0x0029963C
	public static c5x a(aud A_0, Vector3 A_1)
	{
		c5x c5x = new c5x();
		c5x.Location = A_1;
		c5x.Size = new Vector3(0.1f, 0.1f, 0.1f);
		A_0.a(c5x);
		return c5x;
	}

	// Token: 0x06005FBD RID: 24509 RVA: 0x0029B478 File Offset: 0x00299678
	public static void a(this b0b A_0, string A_1)
	{
		if (A_0 != null)
		{
			bm6 aspect = A_0.GetAspect<bm6>();
			if (aspect != null)
			{
				if (string.IsNullOrEmpty(A_1))
				{
					aspect.y6().RemoveProperty(ddq.ay);
					return;
				}
				aspect.y6()[ddq.ay] = new bt4(A_1);
			}
		}
	}
}
