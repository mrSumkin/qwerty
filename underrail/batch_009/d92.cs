using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020018A3 RID: 6307
[eiz("SDA1")]
[Serializable]
public sealed class d92 : btm, ISerializable
{
	// Token: 0x06008601 RID: 34305 RVA: 0x00378380 File Offset: 0x00376580
	private d92(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (ar7)A_0.GetValue("SDA1:IS", typeof(ar7));
			this.b = (bhp)A_0.GetValue("SDA1:IB", typeof(bhp));
			this.c = (ar7)A_0.GetValue("SDA1:TS", typeof(ar7));
			this.d = (bhp)A_0.GetValue("SDA1:TB", typeof(bhp));
			this.e = A_0.GetString("SDA1:DMNS");
			this.f = (bhp)A_0.GetValue("SDA1:DMNB", typeof(bhp));
			this.g = A_0.GetBoolean("SDA1:HLA");
			return;
		}
		if (base.GetType() == typeof(d92))
		{
			this.a = (ar7)A_0.GetValue("_InitiatorStorage", typeof(ar7));
			this.b = (bhp)A_0.GetValue("_InitiatorBinding", typeof(bhp));
			this.c = (ar7)A_0.GetValue("_TargetStorage", typeof(ar7));
			this.d = (bhp)A_0.GetValue("_TargetBinding", typeof(bhp));
			this.e = A_0.GetString("_DialogModelNameStorage");
			this.f = (bhp)A_0.GetValue("_DialogModelNameBinding", typeof(bhp));
			this.g = A_0.GetBoolean("_HarvestLocalActors");
			return;
		}
		this.a = (ar7)A_0.GetValue("StartDialogActivity+_InitiatorStorage", typeof(ar7));
		this.b = (bhp)A_0.GetValue("StartDialogActivity+_InitiatorBinding", typeof(bhp));
		this.c = (ar7)A_0.GetValue("StartDialogActivity+_TargetStorage", typeof(ar7));
		this.d = (bhp)A_0.GetValue("StartDialogActivity+_TargetBinding", typeof(bhp));
		this.e = A_0.GetString("StartDialogActivity+_DialogModelNameStorage");
		this.f = (bhp)A_0.GetValue("StartDialogActivity+_DialogModelNameBinding", typeof(bhp));
		this.g = A_0.GetBoolean("StartDialogActivity+_HarvestLocalActors");
	}

	// Token: 0x06008602 RID: 34306 RVA: 0x0037862C File Offset: 0x0037682C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SDA1:IS", this.a);
		info.AddValue("SDA1:IB", this.b);
		info.AddValue("SDA1:TS", this.c);
		info.AddValue("SDA1:TB", this.d);
		info.AddValue("SDA1:DMNS", this.e);
		info.AddValue("SDA1:DMNB", this.f);
		info.AddValue("SDA1:HLA", this.g);
	}

	// Token: 0x06008603 RID: 34307 RVA: 0x003786B8 File Offset: 0x003768B8
	public bhp a()
	{
		return this.b;
	}

	// Token: 0x06008604 RID: 34308 RVA: 0x003786C0 File Offset: 0x003768C0
	public void c(bhp A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06008605 RID: 34309 RVA: 0x003786CC File Offset: 0x003768CC
	public ar7 d()
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			return this.b.GetValue<ar7>(this);
		}
		return this.a;
	}

	// Token: 0x06008606 RID: 34310 RVA: 0x00378708 File Offset: 0x00376908
	public void b(ar7 A_0)
	{
		if (!ai.b() && this.b != null && this.b.ao7())
		{
			this.b.SetValue<ar7>(this, A_0);
		}
		this.a = A_0;
	}

	// Token: 0x06008607 RID: 34311 RVA: 0x00378744 File Offset: 0x00376944
	public bhp e()
	{
		return this.d;
	}

	// Token: 0x06008608 RID: 34312 RVA: 0x0037874C File Offset: 0x0037694C
	public void a(bhp A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06008609 RID: 34313 RVA: 0x00378758 File Offset: 0x00376958
	public ar7 b()
	{
		if (!ai.b() && this.d != null && this.d.ao7())
		{
			return this.d.GetValue<ar7>(this);
		}
		return this.c;
	}

	// Token: 0x0600860A RID: 34314 RVA: 0x00378794 File Offset: 0x00376994
	public void a(ar7 A_0)
	{
		if (!ai.b() && this.d != null && this.d.ao7())
		{
			this.d.SetValue<ar7>(this, A_0);
		}
		this.c = A_0;
	}

	// Token: 0x0600860B RID: 34315 RVA: 0x003787D0 File Offset: 0x003769D0
	public bhp f()
	{
		return this.f;
	}

	// Token: 0x0600860C RID: 34316 RVA: 0x003787D8 File Offset: 0x003769D8
	public void b(bhp A_0)
	{
		this.f = A_0;
	}

	// Token: 0x0600860D RID: 34317 RVA: 0x003787E4 File Offset: 0x003769E4
	public string g()
	{
		if (!ai.b() && this.f != null && this.f.ao7())
		{
			return this.f.GetValue<string>(this);
		}
		return this.e;
	}

	// Token: 0x0600860E RID: 34318 RVA: 0x00378820 File Offset: 0x00376A20
	public void a(string A_0)
	{
		if (!ai.b() && this.f != null && this.f.ao7())
		{
			this.f.SetValue<string>(this, A_0);
		}
		this.e = A_0;
	}

	// Token: 0x0600860F RID: 34319 RVA: 0x0037885C File Offset: 0x00376A5C
	public bool c()
	{
		return this.g;
	}

	// Token: 0x06008610 RID: 34320 RVA: 0x00378864 File Offset: 0x00376A64
	public void a(bool A_0)
	{
		this.g = A_0;
	}

	// Token: 0x06008611 RID: 34321 RVA: 0x00378870 File Offset: 0x00376A70
	public d92() : base(null)
	{
	}

	// Token: 0x06008612 RID: 34322 RVA: 0x003788A4 File Offset: 0x00376AA4
	protected override bool b4(e6d A_0)
	{
		if (string.IsNullOrWhiteSpace(this.g()))
		{
			throw new Exception("Dialog model name was null or whitespace.");
		}
		ps serviceOrThrow = bpo.GetServiceOrThrow<ps>();
		List<ble> list = new List<ble>();
		if (this.d() != null && this.d().ao() != null)
		{
			j7 aspect = this.d().ao().GetAspect<j7>();
			if (aspect != null)
			{
				list.Add(aspect);
			}
			if (this.d().ao().Area != null)
			{
				list.AddRange(a37.a(this.d().ao().Area));
			}
		}
		if (this.b() != null && this.b().ao() != null)
		{
			j7 aspect2 = this.b().ao().GetAspect<j7>();
			if (aspect2 != null)
			{
				list.Add(aspect2);
			}
			if (this.b().ao().Area != null)
			{
				list.AddRange(a37.a(this.b().ao().Area));
			}
		}
		serviceOrThrow.amu(this.g(), (this.d() != null) ? this.d().ao() : null, (this.b() != null) ? this.b().ao() : null, list, true, false, true, null, false, false);
		return true;
	}

	// Token: 0x0400334B RID: 13131
	private ar7 a;

	// Token: 0x0400334C RID: 13132
	private bhp b = new bhp();

	// Token: 0x0400334D RID: 13133
	private ar7 c;

	// Token: 0x0400334E RID: 13134
	private new bhp d = new bhp();

	// Token: 0x0400334F RID: 13135
	private new string e;

	// Token: 0x04003350 RID: 13136
	private new bhp f = new bhp();

	// Token: 0x04003351 RID: 13137
	private new bool g = true;
}
