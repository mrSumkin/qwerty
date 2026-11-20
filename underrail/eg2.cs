using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;

// Token: 0x020012D4 RID: 4820
[eiz("XTK")]
[Serializable]
public sealed class eg2 : Aspect<c5x>, c98, chb
{
	// Token: 0x06006A96 RID: 27286 RVA: 0x002CE840 File Offset: 0x002CCA40
	private eg2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetDouble("XTK:C");
		this.b = A_0.GetDouble("XTK:R");
		this.c = (A_0.GetValue("XTK:O", typeof(ar7)) as ar7);
	}

	// Token: 0x06006A97 RID: 27287 RVA: 0x002CE898 File Offset: 0x002CCA98
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XTK:C", this.a);
		info.AddValue("XTK:R", this.b);
		info.AddValue("XTK:O", this.c);
	}

	// Token: 0x06006A98 RID: 27288 RVA: 0x002CE8E0 File Offset: 0x002CCAE0
	public double e()
	{
		return this.b;
	}

	// Token: 0x06006A99 RID: 27289 RVA: 0x002CE8E8 File Offset: 0x002CCAE8
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006A9A RID: 27290 RVA: 0x002CE8F4 File Offset: 0x002CCAF4
	public ar7 f()
	{
		return this.c;
	}

	// Token: 0x06006A9B RID: 27291 RVA: 0x002CE8FC File Offset: 0x002CCAFC
	public void a(ar7 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06006A9C RID: 27292 RVA: 0x002CE908 File Offset: 0x002CCB08
	public eg2(c5x A_0) : base(A_0)
	{
		this.b();
	}

	// Token: 0x06006A9D RID: 27293 RVA: 0x002CE91C File Offset: 0x002CCB1C
	public void r7(eds A_0)
	{
		if (!dz6.e())
		{
			this.b -= A_0.b.TotalMilliseconds;
			if ((this.a -= A_0.b.TotalMilliseconds) <= 0.0)
			{
				this.a += (double)d0u.b;
				this.a();
				return;
			}
		}
		else
		{
			this.a = (double)d0u.b;
		}
	}

	// Token: 0x06006A9E RID: 27294 RVA: 0x002CE99C File Offset: 0x002CCB9C
	public void c()
	{
		this.b -= (double)d0u.b;
		this.a();
	}

	// Token: 0x06006A9F RID: 27295 RVA: 0x002CE9BC File Offset: 0x002CCBBC
	public void d()
	{
		base.a8().RemoveAspect<eg2>();
		c5x c5x = Enumerable.FirstOrDefault<b0b>(Enumerable.Where<b0b>(Enumerable.First<ak1>(base.a8().l).c.Values, new Func<b0b, bool>(eg2.a.a.a))) as c5x;
		awx awx = new awx();
		awx.b(false);
		awx.c(false);
		List<auv> list = awx.ad();
		e01 e = new e01();
		e.a(false);
		e.a("PurpleSparkExpiration");
		e.b(true);
		e.a(1);
		e.a(double.MaxValue);
		a4s a4s = new a4s(e, null, null, null);
		a4s.b(new ar7(base.a8()));
		list.Add(a4s);
		if (c5x != null)
		{
			List<auv> list2 = awx.ad();
			a4s a4s2 = new a4s(new bfq("TelekineticProxyDestroy"), null, null, null);
			a4s2.b(new ar7(c5x));
			list2.Add(a4s2);
		}
		List<auv> list3 = awx.ad();
		c7 c = new c7(base.a8(), false, false, true, false);
		c.a(true);
		list3.Add(c);
		base.a8().i.b.b(awx, atp.a);
		dz6.a(awx);
	}

	// Token: 0x06006AA0 RID: 27296 RVA: 0x002CEAFC File Offset: 0x002CCCFC
	public void b()
	{
		this.a = (double)d0u.b;
		this.b = (double)(d0u.b * ci5.f);
	}

	// Token: 0x06006AA1 RID: 27297 RVA: 0x002CEB1C File Offset: 0x002CCD1C
	private void a()
	{
		if (this.b <= 0.0 && base.a8().i.b != null)
		{
			this.d();
		}
	}

	// Token: 0x04002BC6 RID: 11206
	private double a;

	// Token: 0x04002BC7 RID: 11207
	private double b;

	// Token: 0x04002BC8 RID: 11208
	private ar7 c;

	// Token: 0x020012D5 RID: 4821
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06006AA4 RID: 27300 RVA: 0x002CEB64 File Offset: 0x002CCD64
		internal bool a(b0b A_0)
		{
			return A_0.f;
		}

		// Token: 0x04002BC9 RID: 11209
		public static readonly eg2.a a = new eg2.a();

		// Token: 0x04002BCA RID: 11210
		public static Func<b0b, bool> b;
	}
}
