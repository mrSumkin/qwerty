using System;
using System.Runtime.Serialization;

// Token: 0x02001856 RID: 6230
[eiz("ULES")]
[Serializable]
public sealed class ays : dvv, ISerializable
{
	// Token: 0x060084DF RID: 34015 RVA: 0x00373CC8 File Offset: 0x00371EC8
	private ays(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (ar7)A_0.GetValue("ULES:ER", typeof(ar7));
		this.b = A_0.GetBoolean("ULES:WFSFF");
		this.c = A_0.GetBoolean("ULES:WFNLS");
		this.d = A_0.GetBoolean("ULES:AI");
	}

	// Token: 0x060084E0 RID: 34016 RVA: 0x00373D38 File Offset: 0x00371F38
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ULES:ER", this.a);
		info.AddValue("ULES:WFSFF", this.b);
		info.AddValue("ULES:WFNLS", this.c);
		info.AddValue("ULES:AI", this.d);
	}

	// Token: 0x060084E1 RID: 34017 RVA: 0x00373D94 File Offset: 0x00371F94
	private c5x b()
	{
		return this.a.ao() as c5x;
	}

	// Token: 0x060084E2 RID: 34018 RVA: 0x00373DA8 File Offset: 0x00371FA8
	public ays(b0b A_0, bool A_1 = false, bool A_2 = false, bool A_3 = true)
	{
		czh.a(A_0, "entity");
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
		this.a = new ar7(A_0);
	}

	// Token: 0x060084E3 RID: 34019 RVA: 0x00373DE4 File Offset: 0x00371FE4
	protected override dc4 dt()
	{
		if (this.d)
		{
			return this.a();
		}
		return dc4.b;
	}

	// Token: 0x060084E4 RID: 34020 RVA: 0x00373DFC File Offset: 0x00371FFC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return this.a();
	}

	// Token: 0x060084E5 RID: 34021 RVA: 0x00373E04 File Offset: 0x00372004
	private dc4 a()
	{
		if (this.b() == null || this.b().j == cgy.a)
		{
			return dc4.c;
		}
		cmh cmh;
		if (this.b)
		{
			cmh = bmj.b(this.b());
		}
		else
		{
			cmh = null;
		}
		bool flag = this.c && (this.b() != null && this.b().v.b != null) && this.b().v.b.b();
		if ((!this.b || cmh == null) && (!this.c || !flag))
		{
			this.b().h();
			return dc4.c;
		}
		return dc4.b;
	}

	// Token: 0x040032EF RID: 13039
	private new ar7 a;

	// Token: 0x040032F0 RID: 13040
	private bool b;

	// Token: 0x040032F1 RID: 13041
	private bool c;

	// Token: 0x040032F2 RID: 13042
	private bool d = true;
}
