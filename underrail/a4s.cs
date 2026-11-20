using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02001850 RID: 6224
[eiz("EJA1")]
[Serializable]
public sealed class a4s : b1z, ISerializable
{
	// Token: 0x060084B3 RID: 33971 RVA: 0x003730DC File Offset: 0x003712DC
	private a4s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (cze)A_0.GetValue("EJA1:J", typeof(cze));
		this.b = (ar7)A_0.GetValue("EJA1:I", typeof(ar7));
		this.c = (ar7)A_0.GetValue("EJA1:T", typeof(ar7));
		di7.ReadDictionary<string, object>("EJA1:CD", ref this.d, A_0);
	}

	// Token: 0x060084B4 RID: 33972 RVA: 0x00373164 File Offset: 0x00371364
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EJA1:J", this.a);
		info.AddValue("EJA1:I", this.b);
		info.AddValue("EJA1:T", this.c);
		di7.WriteDictionary<string, object>("EJA1:CD", this.d, info);
	}

	// Token: 0x060084B5 RID: 33973 RVA: 0x003731C0 File Offset: 0x003713C0
	public cze b()
	{
		return this.a;
	}

	// Token: 0x060084B6 RID: 33974 RVA: 0x003731C8 File Offset: 0x003713C8
	public void a(cze A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060084B7 RID: 33975 RVA: 0x003731D4 File Offset: 0x003713D4
	public ar7 d()
	{
		return this.b;
	}

	// Token: 0x060084B8 RID: 33976 RVA: 0x003731DC File Offset: 0x003713DC
	public void a(ar7 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060084B9 RID: 33977 RVA: 0x003731E8 File Offset: 0x003713E8
	public ar7 c()
	{
		return this.c;
	}

	// Token: 0x060084BA RID: 33978 RVA: 0x003731F0 File Offset: 0x003713F0
	public void b(ar7 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060084BB RID: 33979 RVA: 0x003731FC File Offset: 0x003713FC
	public Dictionary<string, object> a()
	{
		return this.d;
	}

	// Token: 0x060084BC RID: 33980 RVA: 0x00373204 File Offset: 0x00371404
	public void a(Dictionary<string, object> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060084BD RID: 33981 RVA: 0x00373210 File Offset: 0x00371410
	public a4s()
	{
	}

	// Token: 0x060084BE RID: 33982 RVA: 0x00373218 File Offset: 0x00371418
	public a4s(cze A_0, ar7 A_1 = null, ar7 A_2 = null, Dictionary<string, object> A_3 = null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x060084BF RID: 33983 RVA: 0x00373240 File Offset: 0x00371440
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a != null)
		{
			this.a.ym((this.b != null) ? this.b.ao() : null, (this.c != null) ? this.c.ao() : null, this.d ?? new Dictionary<string, object>());
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x040032DC RID: 13020
	private new cze a;

	// Token: 0x040032DD RID: 13021
	private ar7 b;

	// Token: 0x040032DE RID: 13022
	private ar7 c;

	// Token: 0x040032DF RID: 13023
	private Dictionary<string, object> d;
}
