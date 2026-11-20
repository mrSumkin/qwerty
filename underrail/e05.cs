using System;
using System.Runtime.Serialization;

// Token: 0x020011B0 RID: 4528
[eiz("PCPP")]
[Serializable]
public sealed class e05 : bdw, ISerializable
{
	// Token: 0x06006079 RID: 24697 RVA: 0x002A2CE8 File Offset: 0x002A0EE8
	private e05(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("PCPP:C");
	}

	// Token: 0x0600607A RID: 24698 RVA: 0x002A2D04 File Offset: 0x002A0F04
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("PCPP:C", this.a);
	}

	// Token: 0x0600607B RID: 24699 RVA: 0x002A2D18 File Offset: 0x002A0F18
	public string a()
	{
		return this.a;
	}

	// Token: 0x0600607C RID: 24700 RVA: 0x002A2D20 File Offset: 0x002A0F20
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600607D RID: 24701 RVA: 0x002A2D2C File Offset: 0x002A0F2C
	public e05()
	{
	}

	// Token: 0x0600607E RID: 24702 RVA: 0x002A2D34 File Offset: 0x002A0F34
	public void av(c1a A_0, cyt A_1)
	{
		if (!string.IsNullOrWhiteSpace(this.a))
		{
			bpo.GetServiceOrThrow<ps>().am3(this.a);
		}
	}

	// Token: 0x04002919 RID: 10521
	private string a;
}
