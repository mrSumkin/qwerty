using System;
using System.Runtime.Serialization;

// Token: 0x020011B3 RID: 4531
[eiz("PSL")]
[Serializable]
public sealed class cfr : ISerializable
{
	// Token: 0x06006086 RID: 24710 RVA: 0x002A2DFC File Offset: 0x002A0FFC
	private cfr(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("PSL:C");
		this.b = A_0.GetBoolean("PSL:L");
		this.c = A_0.GetString("PSL:D");
	}

	// Token: 0x06006087 RID: 24711 RVA: 0x002A2E44 File Offset: 0x002A1044
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("PSL:C", this.a);
		info.AddValue("PSL:L", this.b);
		info.AddValue("PSL:D", this.c);
	}

	// Token: 0x06006088 RID: 24712 RVA: 0x002A2E7C File Offset: 0x002A107C
	public string c()
	{
		return this.a;
	}

	// Token: 0x06006089 RID: 24713 RVA: 0x002A2E84 File Offset: 0x002A1084
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600608A RID: 24714 RVA: 0x002A2E90 File Offset: 0x002A1090
	public bool b()
	{
		return this.b;
	}

	// Token: 0x0600608B RID: 24715 RVA: 0x002A2E98 File Offset: 0x002A1098
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600608C RID: 24716 RVA: 0x002A2EA4 File Offset: 0x002A10A4
	public string a()
	{
		return this.c;
	}

	// Token: 0x0600608D RID: 24717 RVA: 0x002A2EAC File Offset: 0x002A10AC
	public void b(string A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600608E RID: 24718 RVA: 0x002A2EB8 File Offset: 0x002A10B8
	public cfr()
	{
	}

	// Token: 0x0400291F RID: 10527
	private string a;

	// Token: 0x04002920 RID: 10528
	private bool b;

	// Token: 0x04002921 RID: 10529
	private string c;
}
