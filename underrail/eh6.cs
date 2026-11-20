using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Data;

// Token: 0x020012BD RID: 4797
[a(typeof(bim))]
[eiz("TREA")]
[Serializable]
public sealed class eh6 : bim, ISerializable, c98
{
	// Token: 0x060069C4 RID: 27076 RVA: 0x002C977C File Offset: 0x002C797C
	private eh6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("TREA:A");
		this.b = A_0.GetString("TREA:I");
	}

	// Token: 0x060069C5 RID: 27077 RVA: 0x002C97A8 File Offset: 0x002C79A8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TREA:A", this.a);
		info.AddValue("TREA:I", this.b);
	}

	// Token: 0x060069C6 RID: 27078 RVA: 0x002C97D4 File Offset: 0x002C79D4
	public bool b()
	{
		return this.a;
	}

	// Token: 0x060069C7 RID: 27079 RVA: 0x002C97DC File Offset: 0x002C79DC
	public string e()
	{
		return this.b;
	}

	// Token: 0x060069C8 RID: 27080 RVA: 0x002C97E4 File Offset: 0x002C79E4
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060069C9 RID: 27081 RVA: 0x002C97F0 File Offset: 0x002C79F0
	public eh6(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060069CA RID: 27082 RVA: 0x002C97FC File Offset: 0x002C79FC
	public override void mx()
	{
		base.mx();
		this.a(0f);
	}

	// Token: 0x060069CB RID: 27083 RVA: 0x002C9810 File Offset: 0x002C7A10
	public override void my()
	{
		base.my();
		this.a(0f);
	}

	// Token: 0x060069CC RID: 27084 RVA: 0x002C9828 File Offset: 0x002C7A28
	public void r7(eds A_0)
	{
		if (base.a8() != null && base.a8().o.b != null)
		{
			this.a();
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().Area == base.a8().Area)
			{
				if (dk2.f() && serviceOrThrow.aqu().v().StatusEffects.a(cwy.a))
				{
					double num = aw1.b(base.a8(), serviceOrThrow.aqu().v().b());
					float a_ = d05.b(0f, (float)(5.0 - num) / 3f, 1f);
					this.a(a_, A_0.b.TotalMilliseconds);
					return;
				}
				this.a(0f, A_0.b.TotalMilliseconds);
				return;
			}
			else
			{
				this.a(0f);
			}
		}
	}

	// Token: 0x060069CD RID: 27085 RVA: 0x002C9954 File Offset: 0x002C7B54
	public void d()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			this.a = true;
			string name = "riftAttunement_" + this.b;
			serviceOrThrow.aqu().r()[name] = true;
			this.a();
		}
	}

	// Token: 0x060069CE RID: 27086 RVA: 0x002C99A8 File Offset: 0x002C7BA8
	protected override void mz(c5x A_0, string A_1 = null)
	{
		if (A_0 != null && A_0.IsPlayer)
		{
			PropertyCollection propertyCollection = new PropertyCollection();
			propertyCollection["RiftId"] = this.b;
			propertyCollection["Attuned"] = this.a;
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary["tempContext"] = propertyCollection;
			a72 a = new a72();
			a.b("Interfacing\\Rift");
			a.ym(A_0, base.a8(), dictionary);
		}
	}

	// Token: 0x060069CF RID: 27087 RVA: 0x002C9A24 File Offset: 0x002C7C24
	private void a(float A_0)
	{
		if (base.a8() != null)
		{
			if (base.a8().o.b != null)
			{
				base.a8().o.b.d = new float?(A_0);
			}
			if (base.a8().v.b != null)
			{
				base.a8().v.b.a("rift", A_0);
			}
		}
		base.g(A_0 > 0f);
	}

	// Token: 0x060069D0 RID: 27088 RVA: 0x002C9AAC File Offset: 0x002C7CAC
	private void a(float A_0, double A_1)
	{
		if (base.a8() != null && base.a8().o.b != null)
		{
			float valueOrDefault = base.a8().o.b.d.GetValueOrDefault(1f);
			float num = (float)(A_1 * 0.001);
			if (valueOrDefault < A_0)
			{
				this.a(Math.Min(A_0, base.a8().o.b.d.GetValueOrDefault(1f) + num));
				return;
			}
			if (valueOrDefault > A_0)
			{
				this.a(Math.Max(A_0, base.a8().o.b.d.GetValueOrDefault(1f) - num));
			}
		}
	}

	// Token: 0x060069D1 RID: 27089 RVA: 0x002C9B70 File Offset: 0x002C7D70
	private void a()
	{
		if (base.a8() != null && base.a8().o.b != null)
		{
			if (this.a)
			{
				base.a8().o.b.b = new Point(base.a8().o.b.b.X, 2);
				return;
			}
			base.a8().o.b.b = new Point(base.a8().o.b.b.X, 1);
		}
	}

	// Token: 0x04002B91 RID: 11153
	private new bool a;

	// Token: 0x04002B92 RID: 11154
	private string b;
}
