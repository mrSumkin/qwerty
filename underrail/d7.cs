using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000FE6 RID: 4070
[eiz("SODNF")]
[Serializable]
public sealed class d7 : ISerializable
{
	// Token: 0x060053C3 RID: 21443 RVA: 0x0025175C File Offset: 0x0024F95C
	private d7(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("SODNF:C");
		di7.ReadList<string>("SODNF:P", ref this.b, A_0);
		this.c = A_0.GetBoolean("SODNF:O");
		this.d = A_0.GetInt32("SODNF:D");
		this.e = A_0.GetBoolean("SODNF:F");
	}

	// Token: 0x060053C4 RID: 21444 RVA: 0x002517D0 File Offset: 0x0024F9D0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("SODNF:C", this.a);
		di7.WriteList<string>("SODNF:P", this.b, info);
		info.AddValue("SODNF:O", this.c);
		info.AddValue("SODNF:D", this.d);
		info.AddValue("SODNF:F", this.e);
	}

	// Token: 0x060053C5 RID: 21445 RVA: 0x00251834 File Offset: 0x0024FA34
	public string e()
	{
		return this.a;
	}

	// Token: 0x060053C6 RID: 21446 RVA: 0x0025183C File Offset: 0x0024FA3C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060053C7 RID: 21447 RVA: 0x00251848 File Offset: 0x0024FA48
	public List<string> c()
	{
		return this.b;
	}

	// Token: 0x060053C8 RID: 21448 RVA: 0x00251850 File Offset: 0x0024FA50
	public void a(List<string> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060053C9 RID: 21449 RVA: 0x0025185C File Offset: 0x0024FA5C
	public bool a()
	{
		return this.c;
	}

	// Token: 0x060053CA RID: 21450 RVA: 0x00251864 File Offset: 0x0024FA64
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x060053CB RID: 21451 RVA: 0x00251870 File Offset: 0x0024FA70
	public int b()
	{
		return this.d;
	}

	// Token: 0x060053CC RID: 21452 RVA: 0x00251878 File Offset: 0x0024FA78
	public void a(int A_0)
	{
		this.d = A_0;
	}

	// Token: 0x060053CD RID: 21453 RVA: 0x00251884 File Offset: 0x0024FA84
	public bool d()
	{
		return this.e;
	}

	// Token: 0x060053CE RID: 21454 RVA: 0x0025188C File Offset: 0x0024FA8C
	public void a(bool A_0)
	{
		this.e = A_0;
	}

	// Token: 0x060053CF RID: 21455 RVA: 0x00251898 File Offset: 0x0024FA98
	public d7()
	{
	}

	// Token: 0x060053D0 RID: 21456 RVA: 0x002518AC File Offset: 0x0024FAAC
	public override string ToString()
	{
		if (!string.IsNullOrEmpty(this.a))
		{
			return this.a;
		}
		return base.ToString();
	}

	// Token: 0x0400222B RID: 8747
	private string a;

	// Token: 0x0400222C RID: 8748
	private List<string> b = new List<string>();

	// Token: 0x0400222D RID: 8749
	private bool c;

	// Token: 0x0400222E RID: 8750
	private int d;

	// Token: 0x0400222F RID: 8751
	private bool e;
}
