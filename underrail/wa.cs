using System;
using System.Runtime.Serialization;

// Token: 0x0200071D RID: 1821
[eiz("CO")]
[Serializable]
public sealed class wa : ISerializable
{
	// Token: 0x06002F58 RID: 12120 RVA: 0x0011EF5C File Offset: 0x0011D15C
	private wa(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CO:B");
			this.b = A_0.GetDouble("CO:C");
			return;
		}
		if (base.GetType() == typeof(wa))
		{
			this.a = A_0.GetString("_Blueprint");
			this.b = A_0.GetDouble("_Chance");
			return;
		}
		this.a = A_0.GetString("CharacterOpportunity+_Blueprint");
		this.b = A_0.GetDouble("CharacterOpportunity+_Chance");
	}

	// Token: 0x06002F59 RID: 12121 RVA: 0x0011EFFC File Offset: 0x0011D1FC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CO:B", this.a);
		info.AddValue("CO:C", this.b);
	}

	// Token: 0x06002F5A RID: 12122 RVA: 0x0011F020 File Offset: 0x0011D220
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002F5B RID: 12123 RVA: 0x0011F028 File Offset: 0x0011D228
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002F5C RID: 12124 RVA: 0x0011F034 File Offset: 0x0011D234
	public double b()
	{
		return this.b;
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x0011F03C File Offset: 0x0011D23C
	public void a(double A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x0011F048 File Offset: 0x0011D248
	public wa()
	{
	}

	// Token: 0x04001A2F RID: 6703
	private string a;

	// Token: 0x04001A30 RID: 6704
	private double b;
}
