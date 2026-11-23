using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001099 RID: 4249
[eiz("DPJ1")]
[Serializable]
public sealed class doj : cze, ISerializable
{
	// Token: 0x06005915 RID: 22805 RVA: 0x0026903C File Offset: 0x0026723C
	private doj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("DPJ1:PV");
	}

	// Token: 0x06005916 RID: 22806 RVA: 0x00269058 File Offset: 0x00267258
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DPJ1:PV", this.a);
	}

	// Token: 0x06005917 RID: 22807 RVA: 0x00269074 File Offset: 0x00267274
	public int a()
	{
		return this.a;
	}

	// Token: 0x06005918 RID: 22808 RVA: 0x0026907C File Offset: 0x0026727C
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005919 RID: 22809 RVA: 0x00269088 File Offset: 0x00267288
	public doj()
	{
	}

	// Token: 0x0600591A RID: 22810 RVA: 0x00269094 File Offset: 0x00267294
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
		if (serviceOrThrow.aqu() != null && c5x != null)
		{
			int a_ = (int)(c5x.h.b.aa().Defense.q().zm() / 100f * (float)this.a());
			cwt cwt = new cwt();
			cwt.b = true;
			cwt.p = true;
			cwt.l = true;
			cwt.f.Add(new csk(DamageType.Mechanical, a_));
			cwt.y = "{2} получает ";
			akg a_2 = new akg(null, c5x.h.b, cwt, null, false);
			c5x.Zone.ActionManager.g9(a_2, atp.a);
		}
	}

	// Token: 0x040023DA RID: 9178
	private new int a;
}
