using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

// Token: 0x02001448 RID: 5192
[eiz("FLIA2")]
[Serializable]
public sealed class b6j : b1z, ISerializable
{
	// Token: 0x060074B8 RID: 29880 RVA: 0x00317D64 File Offset: 0x00315F64
	private b6j(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("FLIA2:L", typeof(ar7)) as ar7);
		this.b = A_0.GetString("FLIA2:N");
		this.c = (A_0.GetValue("FLIA2:S", typeof(float?)) as float?);
		this.d = A_0.GetSingle("FLIA2:E");
		this.e = A_0.GetSingle("FLIA2:C");
		this.f = A_0.GetBoolean("FLIA2:D");
	}

	// Token: 0x060074B9 RID: 29881 RVA: 0x00317E10 File Offset: 0x00316010
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FLIA2:L", this.a);
		info.AddValue("FLIA2:N", this.b);
		info.AddValue("FLIA2:S", this.c);
		info.AddValue("FLIA2:E", this.d);
		info.AddValue("FLIA2:C", this.e);
		info.AddValue("FLIA2:D", this.f);
	}

	// Token: 0x060074BA RID: 29882 RVA: 0x00317E90 File Offset: 0x00316090
	public b6j(ar7 A_0, string A_1, float? A_2, float A_3, float A_4, bool A_5 = false)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.e = A_4;
		this.f = A_5;
	}

	// Token: 0x060074BB RID: 29883 RVA: 0x00317ED0 File Offset: 0x003160D0
	protected override dc4 dt()
	{
		ah7 ah = this.a();
		if (ah == null)
		{
			return dc4.e;
		}
		ah.Light = new ae8(ah.Light.d(), (this.c != null) ? this.c.Value : ah.Light.c(), ah.Light.a());
		ah.d();
		return dc4.b;
	}

	// Token: 0x060074BC RID: 29884 RVA: 0x00317F48 File Offset: 0x00316148
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		ah7 ah = this.a();
		if (ah == null)
		{
			return dc4.e;
		}
		float num = ah.Light.c();
		num += (float)(A_1.TotalMilliseconds * (double)this.e);
		bool flag = false;
		if (Math.Sign(this.e) == 1)
		{
			if (num >= this.d)
			{
				flag = true;
				num = this.d;
			}
		}
		else if (num <= this.d)
		{
			flag = true;
			num = this.d;
		}
		ah.Light = new ae8(ah.Light.d(), num, ah.Light.a());
		ah.d();
		if (flag)
		{
			if (this.f)
			{
				this.b().ig();
			}
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x060074BD RID: 29885 RVA: 0x00318018 File Offset: 0x00316218
	private bsf b()
	{
		if (this.a == null || this.a.ao() == null || string.IsNullOrEmpty(this.b))
		{
			return null;
		}
		return Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(this.a.ao().RaysEmitters), new Func<bsf, bool>(this.a)));
	}

	// Token: 0x060074BE RID: 29886 RVA: 0x00318080 File Offset: 0x00316280
	private ah7 a()
	{
		if (this.a == null || this.a.ao() == null || string.IsNullOrEmpty(this.b))
		{
			return null;
		}
		bsf bsf = this.b();
		if (bsf != null)
		{
			return bsf.Definition;
		}
		return null;
	}

	// Token: 0x060074BF RID: 29887 RVA: 0x003180D0 File Offset: 0x003162D0
	[CompilerGenerated]
	private bool a(bsf A_0)
	{
		return A_0.Definition != null && A_0.Definition.Name == this.b;
	}

	// Token: 0x04002FAE RID: 12206
	private new ar7 a;

	// Token: 0x04002FAF RID: 12207
	private string b;

	// Token: 0x04002FB0 RID: 12208
	private float? c;

	// Token: 0x04002FB1 RID: 12209
	private float d;

	// Token: 0x04002FB2 RID: 12210
	private float e = -0.001f;

	// Token: 0x04002FB3 RID: 12211
	private bool f;
}
