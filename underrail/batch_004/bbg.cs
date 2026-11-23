using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x020000BF RID: 191
[eiz("RC")]
[Serializable]
public sealed class bbg : ISerializable
{
	// Token: 0x06000444 RID: 1092 RVA: 0x00013D04 File Offset: 0x00011F04
	private bbg(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadList<ok>("RC:PP", ref this.a, A_0);
			di7.ReadList<aue>("RC:IP", ref this.b, A_0);
			this.c = A_0.GetSingle("RC:R");
			this.d = A_0.GetBoolean("RC:PSN");
			return;
		}
		if (base.GetType() == typeof(bbg))
		{
			this.a = (List<ok>)A_0.GetValue("_PenetrationPredicates", typeof(List<ok>));
			this.b = (List<aue>)A_0.GetValue("_ImpactPredicates", typeof(List<aue>));
			this.c = A_0.GetSingle("_Range");
			this.d = A_0.GetBoolean("_PenetrateSourceNode");
			return;
		}
		this.a = (List<ok>)A_0.GetValue("RayConfiguration+_PenetrationPredicates", typeof(List<ok>));
		this.b = (List<aue>)A_0.GetValue("RayConfiguration+_ImpactPredicates", typeof(List<aue>));
		this.c = A_0.GetSingle("RayConfiguration+_Range");
		this.d = A_0.GetBoolean("RayConfiguration+_PenetrateSourceNode");
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00013E5C File Offset: 0x0001205C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<ok>("RC:PP", this.a, info);
		di7.WriteList<aue>("RC:IP", this.b, info);
		info.AddValue("RC:R", this.c);
		info.AddValue("RC:PSN", this.d);
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00013EB0 File Offset: 0x000120B0
	public List<ok> a()
	{
		return this.a;
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x00013EB8 File Offset: 0x000120B8
	public void a(List<ok> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00013EC4 File Offset: 0x000120C4
	public List<aue> c()
	{
		return this.b;
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00013ECC File Offset: 0x000120CC
	public void a(List<aue> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600044A RID: 1098 RVA: 0x00013ED8 File Offset: 0x000120D8
	public float b()
	{
		return this.c;
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00013EE0 File Offset: 0x000120E0
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00013EEC File Offset: 0x000120EC
	public bool d()
	{
		return this.d;
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00013EF4 File Offset: 0x000120F4
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00013F00 File Offset: 0x00012100
	public bbg()
	{
	}

	// Token: 0x0400043E RID: 1086
	private List<ok> a = new List<ok>();

	// Token: 0x0400043F RID: 1087
	private List<aue> b = new List<aue>();

	// Token: 0x04000440 RID: 1088
	private float c;

	// Token: 0x04000441 RID: 1089
	private bool d;
}
