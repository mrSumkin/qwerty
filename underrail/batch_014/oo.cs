using System;
using System.Runtime.Serialization;

// Token: 0x02000FC3 RID: 4035
[eiz("CSTCNC")]
[Serializable]
public sealed class oo : dnh, ISerializable
{
	// Token: 0x060052DD RID: 21213 RVA: 0x0024F17C File Offset: 0x0024D37C
	private oo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("CSTCNC:I");
		this.b = A_0.GetString("CSTCNC:CN");
	}

	// Token: 0x060052DE RID: 21214 RVA: 0x0024F1A8 File Offset: 0x0024D3A8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSTCNC:I", this.a);
		info.AddValue("CSTCNC:CN", this.b);
	}

	// Token: 0x060052DF RID: 21215 RVA: 0x0024F1D4 File Offset: 0x0024D3D4
	public bool b()
	{
		return this.a;
	}

	// Token: 0x060052E0 RID: 21216 RVA: 0x0024F1DC File Offset: 0x0024D3DC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060052E1 RID: 21217 RVA: 0x0024F1E8 File Offset: 0x0024D3E8
	public string a()
	{
		return this.b;
	}

	// Token: 0x060052E2 RID: 21218 RVA: 0x0024F1F0 File Offset: 0x0024D3F0
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060052E3 RID: 21219 RVA: 0x0024F1FC File Offset: 0x0024D3FC
	public oo()
	{
	}

	// Token: 0x060052E4 RID: 21220 RVA: 0x0024F208 File Offset: 0x0024D408
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		if (!string.IsNullOrEmpty(this.b) && A_1 != null)
		{
			ap9 classPropertyValue = A_1.GetClassPropertyValue<ap9>("otherParty");
			return (classPropertyValue != null && classPropertyValue.a.Contains(this.b)) ^ this.a;
		}
		return false;
	}

	// Token: 0x060052E5 RID: 21221 RVA: 0x0024F260 File Offset: 0x0024D460
	public override string ToString()
	{
		if (!string.IsNullOrEmpty(this.b))
		{
			return "Цель " + this.b + ".";
		}
		return "Цель не имеет названия.";
	}

	// Token: 0x040021E9 RID: 8681
	private bool a;

	// Token: 0x040021EA RID: 8682
	private string b;
}
