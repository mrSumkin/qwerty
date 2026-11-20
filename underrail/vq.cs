using System;
using System.IO;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02001168 RID: 4456
public static class vq
{
	// Token: 0x06005F56 RID: 24406 RVA: 0x00287380 File Offset: 0x00285580
	public static c5x a(string A_0, bool A_1 = false)
	{
		c5k c5k = bpo.GetServiceOrThrow<d6j>().dv().a("locale\\" + A_0);
		if (c5k != null)
		{
			c5x c5x = c5k.a(null, A_1) as c5x;
			if (c5x != null)
			{
				c5x.Layer = aju.x;
				if (!A_1)
				{
					ery aspect = c5x.GetAspect<ery>();
					if (aspect != null)
					{
						aspect.e();
					}
				}
			}
			return c5x;
		}
		return null;
	}

	// Token: 0x06005F57 RID: 24407 RVA: 0x002873F8 File Offset: 0x002855F8
	public static c5x a(string A_0, csd A_1, bool A_2 = false)
	{
		if (A_1 != null && A_1.Area != null)
		{
			c5x c5x = vq.a(A_0, A_2);
			if (c5x != null)
			{
				c5x.Location = A_1.Location;
				c5x.VisualDirection = A_1.Direction;
				c5x.Layer = aju.x;
				A_1.Area.a(c5x);
				return c5x;
			}
		}
		return null;
	}

	// Token: 0x06005F58 RID: 24408 RVA: 0x00287458 File Offset: 0x00285658
	public static c5x a(string A_0, c1a A_1, bt4 A_2, bool A_3 = false)
	{
		if (A_2 != null)
		{
			c5x c5x = vq.a(A_0, A_3);
			if (c5x != null)
			{
				aud aud;
				Vector3 a_;
				HorizontalDirection a_2;
				A_2.a(A_1, out aud, out a_, out a_2);
				if (aud != null)
				{
					c5x.Location = a_;
					c5x.VisualDirection = a_2;
					c5x.Layer = aju.x;
					aud.a(c5x);
				}
				return c5x;
			}
		}
		return null;
	}

	// Token: 0x06005F59 RID: 24409 RVA: 0x002874B0 File Offset: 0x002856B0
	public static b0b a(b0b A_0)
	{
		byte[] array = null;
		MemoryStream memoryStream = null;
		b0b result;
		try
		{
			array = dh4.a();
			memoryStream = new MemoryStream(array);
			Stream stream = eoq.SerializeToBinary<b0b>(A_0, dds.a(), memoryStream, eh9.c, true, true);
			stream.Position = 0L;
			b0b b0b = eoq.DeserializeFromBinary<b0b>(stream, dds.a(), true, true);
			b0b.aq();
			result = b0b;
		}
		finally
		{
			if (array != null)
			{
				dh4.a(array);
			}
			if (memoryStream != null)
			{
				memoryStream.Dispose();
			}
		}
		return result;
	}

	// Token: 0x06005F5A RID: 24410 RVA: 0x0028752C File Offset: 0x0028572C
	public static c5x a(c5x A_0)
	{
		if (A_0 != null && A_0.Area != null)
		{
			aud aud = A_0.Area;
			A_0.an();
			c5x c5x = vq.a(A_0) as c5x;
			aud.a(A_0);
			c5x.Layer = aju.x;
			c5x.aa = false;
			c5x.ae = new float?(0f);
			c5x.aq();
			c5x.i(Guid.NewGuid());
			c5x.v();
			cm aspect = new cm(c5x, 300000, false);
			c5x.SetAspect<cm>(aspect);
			do6 aspect2 = new do6(c5x);
			c5x.SetAspect<do6>(aspect2);
			aud.a(c5x);
			return c5x;
		}
		return null;
	}

	// Token: 0x06005F5B RID: 24411 RVA: 0x002875D0 File Offset: 0x002857D0
	public static void a(b0b A_0, b0b A_1)
	{
		if (A_0 == null || A_1 == null)
		{
			return;
		}
		A_1.ac = A_0.ac;
		A_1.ad = A_0.ad;
	}
}
