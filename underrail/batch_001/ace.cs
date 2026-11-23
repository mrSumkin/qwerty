using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200189A RID: 6298
[eiz("EJA2")]
[Serializable]
public sealed class ace : btm, ISerializable
{
	// Token: 0x060085C9 RID: 34249 RVA: 0x00377708 File Offset: 0x00375908
	private ace(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (cze)A_0.GetValue("EJA2:J", typeof(cze));
		di7.ReadDictionary<string, object>("EJA2:CD", ref this.b, A_0);
		di7.ReadList<dra>("EJA2:B", ref this.c, A_0);
		this.e = (A_0.GetValue("EJA2:I", typeof(ar7)) as ar7);
		this.d = (A_0.GetValue("EJA2:T", typeof(ar7)) as ar7);
	}

	// Token: 0x060085CA RID: 34250 RVA: 0x003777B8 File Offset: 0x003759B8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EJA2:J", this.a);
		di7.WriteDictionary<string, object>("EJA2:CD", this.b, info);
		di7.WriteList<dra>("EJA2:B", this.c, info);
	}

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x060085CB RID: 34251 RVA: 0x003777F8 File Offset: 0x003759F8
	// (set) Token: 0x060085CC RID: 34252 RVA: 0x00377800 File Offset: 0x00375A00
	public cze Job
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x060085CD RID: 34253 RVA: 0x0037780C File Offset: 0x00375A0C
	public Dictionary<string, object> CustomData
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x060085CE RID: 34254 RVA: 0x00377814 File Offset: 0x00375A14
	private List<dra> Bindings
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x060085CF RID: 34255 RVA: 0x0037781C File Offset: 0x00375A1C
	// (set) Token: 0x060085D0 RID: 34256 RVA: 0x00377824 File Offset: 0x00375A24
	public ar7 InitiatorRef
	{
		get
		{
			return this.e;
		}
		set
		{
			this.e = value;
		}
	}

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x060085D1 RID: 34257 RVA: 0x00377830 File Offset: 0x00375A30
	// (set) Token: 0x060085D2 RID: 34258 RVA: 0x00377838 File Offset: 0x00375A38
	public ar7 TargetRef
	{
		get
		{
			return this.d;
		}
		set
		{
			this.d = value;
		}
	}

	// Token: 0x060085D3 RID: 34259 RVA: 0x00377844 File Offset: 0x00375A44
	public ace() : base(null)
	{
	}

	// Token: 0x060085D4 RID: 34260 RVA: 0x00377864 File Offset: 0x00375A64
	public ace(cze A_0) : base(null)
	{
		this.a = A_0;
	}

	// Token: 0x060085D5 RID: 34261 RVA: 0x0037788C File Offset: 0x00375A8C
	protected override bool b4(e6d A_0)
	{
		this.b();
		if (this.a != null)
		{
			this.a.ym((this.e != null) ? this.e.ao() : null, (this.d != null) ? this.d.ao() : null, this.b);
		}
		this.a();
		return true;
	}

	// Token: 0x060085D6 RID: 34262 RVA: 0x003778FC File Offset: 0x00375AFC
	private void b()
	{
		if (this.a != null && this.c != null)
		{
			foreach (dra dra in this.c)
			{
				dra.b(this, this.a);
			}
		}
	}

	// Token: 0x060085D7 RID: 34263 RVA: 0x00377970 File Offset: 0x00375B70
	private void a()
	{
		if (this.a != null && this.c != null)
		{
			foreach (dra dra in this.c)
			{
				dra.a(this, this.a);
			}
		}
	}

	// Token: 0x0400333A RID: 13114
	private cze a;

	// Token: 0x0400333B RID: 13115
	private Dictionary<string, object> b = new Dictionary<string, object>();

	// Token: 0x0400333C RID: 13116
	private List<dra> c = new List<dra>();

	// Token: 0x0400333D RID: 13117
	private new ar7 d;

	// Token: 0x0400333E RID: 13118
	private new ar7 e;
}
