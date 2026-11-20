using System;
using System.Runtime.Serialization;

// Token: 0x020011AF RID: 4527
[eiz("REPP")]
[Serializable]
public sealed class uq : bdw, ISerializable
{
	// Token: 0x06006071 RID: 24689 RVA: 0x002A2C20 File Offset: 0x002A0E20
	private uq(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("REPP:SP");
		this.b = (A_0.GetValue("REPP:TL", typeof(bt4)) as bt4);
	}

	// Token: 0x06006072 RID: 24690 RVA: 0x002A2C64 File Offset: 0x002A0E64
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("REPP:SP", this.a);
		info.AddValue("REPP:TL", this.b);
	}

	// Token: 0x06006073 RID: 24691 RVA: 0x002A2C88 File Offset: 0x002A0E88
	public string a()
	{
		return this.a;
	}

	// Token: 0x06006074 RID: 24692 RVA: 0x002A2C90 File Offset: 0x002A0E90
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06006075 RID: 24693 RVA: 0x002A2C9C File Offset: 0x002A0E9C
	public bt4 b()
	{
		return this.b;
	}

	// Token: 0x06006076 RID: 24694 RVA: 0x002A2CA4 File Offset: 0x002A0EA4
	public void a(bt4 A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06006077 RID: 24695 RVA: 0x002A2CB0 File Offset: 0x002A0EB0
	public uq()
	{
	}

	// Token: 0x06006078 RID: 24696 RVA: 0x002A2CB8 File Offset: 0x002A0EB8
	public void av(c1a A_0, cyt A_1)
	{
		if (!string.IsNullOrWhiteSpace(this.a) && this.b != null)
		{
			crm.a(this.a, this.b);
		}
	}

	// Token: 0x04002917 RID: 10519
	private string a;

	// Token: 0x04002918 RID: 10520
	private bt4 b;
}
