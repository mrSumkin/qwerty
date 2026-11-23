using System;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using Ouroboros.Playfield.Space;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020012B0 RID: 4784
[eiz("DHCEA")]
[Serializable]
public sealed class dzl : Aspect<c5x>, ISerializable, c98, chb
{
	// Token: 0x060068F8 RID: 26872 RVA: 0x002C5340 File Offset: 0x002C3540
	private dzl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("DHCEA:A");
		this.c = A_0.GetBoolean("DHCEA:M");
		this.d = A_0.GetInt32("DHCEA:H");
		this.e = (A_0.GetValue("DHCEA:R", typeof(double?)) as double?);
	}

	// Token: 0x060068F9 RID: 26873 RVA: 0x002C53B8 File Offset: 0x002C35B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DHCEA:A", this.b);
		info.AddValue("DHCEA:M", this.c);
		info.AddValue("DHCEA:H", this.d);
		info.AddValue("DHCEA:R", this.e);
	}

	// Token: 0x060068FA RID: 26874 RVA: 0x002C5418 File Offset: 0x002C3618
	public bool b()
	{
		return this.c;
	}

	// Token: 0x060068FB RID: 26875 RVA: 0x002C5420 File Offset: 0x002C3620
	public void a(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060068FC RID: 26876 RVA: 0x002C542C File Offset: 0x002C362C
	public int d()
	{
		return this.d;
	}

	// Token: 0x060068FD RID: 26877 RVA: 0x002C5434 File Offset: 0x002C3634
	public void b(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060068FE RID: 26878 RVA: 0x002C5440 File Offset: 0x002C3640
	public double? e()
	{
		return this.e;
	}

	// Token: 0x060068FF RID: 26879 RVA: 0x002C5448 File Offset: 0x002C3648
	public void a(double? A_0)
	{
		this.e = A_0;
	}

	// Token: 0x06006900 RID: 26880 RVA: 0x002C5454 File Offset: 0x002C3654
	public dzl(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006901 RID: 26881 RVA: 0x002C5468 File Offset: 0x002C3668
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			this.b += A_0.b.TotalMilliseconds;
			if (this.b > 1500.0)
			{
				this.a();
				this.b = 0.0;
			}
		}
	}

	// Token: 0x06006902 RID: 26882 RVA: 0x002C54C0 File Offset: 0x002C36C0
	public void c()
	{
		this.a();
		this.b = 0.0;
	}

	// Token: 0x06006903 RID: 26883 RVA: 0x002C54D8 File Offset: 0x002C36D8
	public void a(int? A_0)
	{
		if (A_0 != null)
		{
			int num = this.a(A_0.Value);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Area == base.a8().Area && serviceOrThrow.aqu().v().SpecialStates.g && serviceOrThrow.aqu().v().Skills.Get<a2n>().g() >= num)
				{
					return;
				}
			}
		}
		if (this.e != null)
		{
			cnk serviceOrThrow2 = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow2.aqu() != null && new Random(serviceOrThrow2.aqu().l() + base.a8().qe().GetHashCode()).NextDouble() >= this.e.Value)
			{
				return;
			}
		}
		c5x c5x2 = base.a8();
		c1a a_ = c5x2.Zone;
		aud aud = c5x2.Area;
		Vector3 a_2 = c5x2.Location;
		HorizontalDirection a_3 = c5x2.VisualDirection;
		int num2 = 1;
		if (c5x2.o.b != null && c5x2.o.b.a != null)
		{
			string[] array = c5x2.o.b.a.Split(new string[]
			{
				"\\"
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 3 && array[1].Length > "xpbl_hrm".Length && int.TryParse(array[1].Substring("xpbl_hrm".Length), NumberStyles.Number, CultureInfo.InvariantCulture, out num2) && num2 <= 0)
			{
				num2 = 1;
			}
		}
		c5x c5x3;
		if (num2 == 8)
		{
			c5x3 = vq.a("creatures\\xpbl\\gianthermitcrab", a_, new bt4(aud.y8(), a_2), false);
		}
		else
		{
			c5x3 = vq.a("creatures\\xpbl\\hermitcrab", a_, new bt4(aud.y8(), a_2), false);
		}
		if (c5x3 != null)
		{
			c5x2.w();
			c5x2.an();
			c5x3.VisualDirection = a_3;
			if (c5x3.h.b != null && c5x3.i.b != null && c5x3.t.b != null)
			{
				c5x3.h.b.a("xpbl_hermitcrab" + num2.ToString());
				c5x3.t.b.a(false);
				c5x3.h.b.ap = new CharacterState?(CharacterState.Custom1);
				c5x3.h.b.aq = new int?(0);
				awx awx = new awx();
				awx.b(false);
				awx.c(false);
				awx.a(false);
				awx.ad().Add(new e4t(c5x3.h.b, CharacterState.Custom2, cux.a, 0, null, 1));
				awx.ad().Add(new a4s(new epw(null), null, new ar7(c5x3), null));
				awx.ad().Add(new a4s(new b16(null), null, new ar7(c5x3), null));
				awx.ad().Add(new a4s(new clv(true), null, new ar7(c5x3), null));
				c5x3.i.b.b(awx, atp.a);
			}
		}
	}

	// Token: 0x06006904 RID: 26884 RVA: 0x002C5898 File Offset: 0x002C3A98
	private int a(int A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			Random random = new Random(base.a8().qe().GetHashCode() / 2 + serviceOrThrow.aqu().l() / 2);
			double num = 0.75 + Math.Pow(random.NextDouble(), 1.75) * 1.75;
			return (int)((double)A_0 * num);
		}
		return A_0;
	}

	// Token: 0x06006905 RID: 26885 RVA: 0x002C5918 File Offset: 0x002C3B18
	private void a()
	{
		if (!this.c)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Area == base.a8().Area && aw1.b(c5x, base.a8()) <= 4.0)
				{
					ak1 ak = Enumerable.FirstOrDefault<ak1>(base.a8().l);
					if (ak != null && ak.b(dm9.b))
					{
						this.a(new int?(this.d));
					}
				}
			}
		}
	}

	// Token: 0x04002B59 RID: 11097
	private const int a = 1500;

	// Token: 0x04002B5A RID: 11098
	private double b;

	// Token: 0x04002B5B RID: 11099
	private bool c;

	// Token: 0x04002B5C RID: 11100
	private int d = 90;

	// Token: 0x04002B5D RID: 11101
	private double? e;
}
