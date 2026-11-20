using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x0200184F RID: 6223
[eiz("EJA3")]
[Serializable]
public sealed class eae : b1z, ISerializable
{
	// Token: 0x060084A6 RID: 33958 RVA: 0x00372F08 File Offset: 0x00371108
	private eae(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("EJA3:J");
		this.b = (ar7)A_0.GetValue("EJA3:I", typeof(ar7));
		this.c = (ar7)A_0.GetValue("EJA3:T", typeof(ar7));
		di7.ReadDictionary<string, object>("EJA3:CD", ref this.d, A_0);
	}

	// Token: 0x060084A7 RID: 33959 RVA: 0x00372F80 File Offset: 0x00371180
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("EJA3:J", this.a);
		info.AddValue("EJA3:I", this.b);
		info.AddValue("EJA3:T", this.c);
		di7.WriteDictionary<string, object>("EJA3:CD", this.d, info);
	}

	// Token: 0x060084A8 RID: 33960 RVA: 0x00372FDC File Offset: 0x003711DC
	public string d()
	{
		return this.a;
	}

	// Token: 0x060084A9 RID: 33961 RVA: 0x00372FE4 File Offset: 0x003711E4
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060084AA RID: 33962 RVA: 0x00372FF0 File Offset: 0x003711F0
	public ar7 c()
	{
		return this.b;
	}

	// Token: 0x060084AB RID: 33963 RVA: 0x00372FF8 File Offset: 0x003711F8
	public void a(ar7 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060084AC RID: 33964 RVA: 0x00373004 File Offset: 0x00371204
	public ar7 b()
	{
		return this.c;
	}

	// Token: 0x060084AD RID: 33965 RVA: 0x0037300C File Offset: 0x0037120C
	public void b(ar7 A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060084AE RID: 33966 RVA: 0x00373018 File Offset: 0x00371218
	public Dictionary<string, object> a()
	{
		return this.d;
	}

	// Token: 0x060084AF RID: 33967 RVA: 0x00373020 File Offset: 0x00371220
	public void a(Dictionary<string, object> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060084B0 RID: 33968 RVA: 0x0037302C File Offset: 0x0037122C
	public eae()
	{
	}

	// Token: 0x060084B1 RID: 33969 RVA: 0x00373034 File Offset: 0x00371234
	public eae(string A_0, ar7 A_1 = null, ar7 A_2 = null, Dictionary<string, object> A_3 = null)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x060084B2 RID: 33970 RVA: 0x0037305C File Offset: 0x0037125C
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			ea5.a(this.a, ((this.b != null) ? this.b.ao() : null) as c5x, ((this.c != null) ? this.c.ao() : null) as c5x, this.d ?? new Dictionary<string, object>());
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x040032D8 RID: 13016
	private new string a;

	// Token: 0x040032D9 RID: 13017
	private ar7 b;

	// Token: 0x040032DA RID: 13018
	private ar7 c;

	// Token: 0x040032DB RID: 13019
	private Dictionary<string, object> d;
}
