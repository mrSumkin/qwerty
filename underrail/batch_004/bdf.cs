using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;

// Token: 0x0200127A RID: 4730
[eiz("TWEA")]
[Serializable]
public class bdf : Aspect<c5x>, ISerializable, c98, c02
{
	// Token: 0x060066B2 RID: 26290 RVA: 0x002BA484 File Offset: 0x002B8684
	protected bdf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("TWEA:T", typeof(l9?)) as l9?);
		this.b = (A_0.GetValue("TWEA:TW", typeof(ar7)) as ar7);
		this.c = A_0.GetSingle("TWEA:S");
		this.d = A_0.GetDouble("TWEA:C");
		this.e = (A_0.GetValue("TWEA:L", typeof(Vector3?)) as Vector3?);
		this.f = A_0.GetDouble("TWEA:D");
		this.g = A_0.GetDouble("TWEA:B");
	}

	// Token: 0x060066B3 RID: 26291 RVA: 0x002BA570 File Offset: 0x002B8770
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TWEA:T", this.a);
		info.AddValue("TWEA:TW", this.b);
		info.AddValue("TWEA:S", this.c);
		info.AddValue("TWEA:C", this.d);
		info.AddValue("TWEA:L", this.e);
		info.AddValue("TWEA:D", this.f);
		info.AddValue("TWEA:B", this.g);
	}

	// Token: 0x060066B4 RID: 26292 RVA: 0x002BA608 File Offset: 0x002B8808
	public float h9()
	{
		return this.c;
	}

	// Token: 0x060066B5 RID: 26293 RVA: 0x002BA610 File Offset: 0x002B8810
	public float ia()
	{
		return this.c;
	}

	// Token: 0x060066B6 RID: 26294 RVA: 0x002BA618 File Offset: 0x002B8818
	public float h()
	{
		return this.c;
	}

	// Token: 0x060066B7 RID: 26295 RVA: 0x002BA620 File Offset: 0x002B8820
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060066B8 RID: 26296 RVA: 0x002BA62C File Offset: 0x002B882C
	public double g()
	{
		return this.f;
	}

	// Token: 0x060066B9 RID: 26297 RVA: 0x002BA634 File Offset: 0x002B8834
	public void a(double A_0)
	{
		this.f = A_0;
	}

	// Token: 0x060066BA RID: 26298 RVA: 0x002BA640 File Offset: 0x002B8840
	public double d()
	{
		return this.g;
	}

	// Token: 0x060066BB RID: 26299 RVA: 0x002BA648 File Offset: 0x002B8848
	public void b(double A_0)
	{
		this.g = A_0;
	}

	// Token: 0x060066BC RID: 26300 RVA: 0x002BA654 File Offset: 0x002B8854
	public l9? e()
	{
		return this.a;
	}

	// Token: 0x060066BD RID: 26301 RVA: 0x002BA660 File Offset: 0x002B8860
	public void a(l9? A_0)
	{
		l9? l = this.a;
		l9? l2 = A_0;
		if (!(l.GetValueOrDefault() == l2.GetValueOrDefault() & l != null == (l2 != null)))
		{
			this.a = A_0;
			this.b();
		}
	}

	// Token: 0x060066BE RID: 26302 RVA: 0x002BA6AC File Offset: 0x002B88AC
	public ar7 f()
	{
		return this.b;
	}

	// Token: 0x060066BF RID: 26303 RVA: 0x002BA6B4 File Offset: 0x002B88B4
	public void a(ar7 A_0)
	{
		if (this.b != A_0)
		{
			this.b = A_0;
			this.b();
		}
	}

	// Token: 0x060066C0 RID: 26304 RVA: 0x002BA6D0 File Offset: 0x002B88D0
	public bdf(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060066C1 RID: 26305 RVA: 0x002BA704 File Offset: 0x002B8904
	public virtual void r8(c5x A_0, bool A_1 = false)
	{
		this.b = new ar7(A_0);
		this.b();
	}

	// Token: 0x060066C2 RID: 26306 RVA: 0x002BA718 File Offset: 0x002B8918
	public virtual void r9(bool A_0 = false)
	{
		this.b = null;
		this.b();
	}

	// Token: 0x060066C3 RID: 26307 RVA: 0x002BA72C File Offset: 0x002B892C
	public virtual void r7(eds A_0)
	{
		if ((this.d += A_0.b.TotalMilliseconds) > 100.0)
		{
			this.d = 0.0;
			if (this.b == null || this.b.ao() == null || this.b.ao().j != cgy.b)
			{
				this.b();
				return;
			}
			double num = aw1.b(this.b.ao(), base.a8());
			if (num >= this.g)
			{
				this.r9(false);
				return;
			}
			if (num <= this.f)
			{
				this.b();
				return;
			}
			float num2;
			if (this.e == null)
			{
				num2 = float.MaxValue;
			}
			else
			{
				num2 = (this.b.ao().Location - this.e.Value).Length();
			}
			if (!this.a() || num2 > 0.2f)
			{
				this.b();
				this.a(this.b.ao().Location);
			}
		}
	}

	// Token: 0x060066C4 RID: 26308 RVA: 0x002BA860 File Offset: 0x002B8A60
	private void a(Vector3 A_0)
	{
		this.e = new Vector3?(A_0);
		ny ny = base.a8().i.b;
		if (ny == null)
		{
			ny = new ny(base.a8());
			base.a8().SetAspect<ny>(ny);
		}
		mj mj = base.a8().j.b;
		if (mj == null)
		{
			mj = new mj(base.a8(), this);
			base.a8().SetAspect<mj>(mj);
		}
		bpr bpr = new bpr(mj, A_0);
		bpr.a(new ddi(this));
		awx awx = new awx("towing");
		awx.a(m7.b);
		awx.ad().Add(bpr);
		ny.b(awx, atp.a);
	}

	// Token: 0x060066C5 RID: 26309 RVA: 0x002BA914 File Offset: 0x002B8B14
	private void b()
	{
		if (this.a())
		{
			base.a8().i.b.b((cst)base.a8().i.b.a());
			this.d = 8.988465674311579E+307;
			this.e = null;
		}
	}

	// Token: 0x060066C6 RID: 26310 RVA: 0x002BA978 File Offset: 0x002B8B78
	private bool a()
	{
		return base.a8() != null && base.a8().i.b != null && base.a8().i.b.a() != null && base.a8().i.b.a().Name == "towing" && base.a8().i.b.a() is cst;
	}

	// Token: 0x04002A9A RID: 10906
	private l9? a;

	// Token: 0x04002A9B RID: 10907
	private ar7 b;

	// Token: 0x04002A9C RID: 10908
	private float c = 1.5f;

	// Token: 0x04002A9D RID: 10909
	private double d;

	// Token: 0x04002A9E RID: 10910
	private Vector3? e;

	// Token: 0x04002A9F RID: 10911
	private double f = 0.5;

	// Token: 0x04002AA0 RID: 10912
	private double g = 2.5;
}
