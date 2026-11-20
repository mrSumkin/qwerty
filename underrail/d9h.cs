using System;
using System.Runtime.Serialization;

// Token: 0x020005ED RID: 1517
[eiz("SMLMC")]
[Serializable]
public sealed class d9h : dth, ISerializable
{
	// Token: 0x060027D1 RID: 10193 RVA: 0x000E6E30 File Offset: 0x000E5030
	private d9h(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetInt32("SMLMC:L");
		this.b = A_0.GetString("SMLMC:M");
	}

	// Token: 0x060027D2 RID: 10194 RVA: 0x000E6E5C File Offset: 0x000E505C
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("SMLMC:L", this.a);
		info.AddValue("SMLMC:M", this.b);
	}

	// Token: 0x060027D3 RID: 10195 RVA: 0x000E6E80 File Offset: 0x000E5080
	public int a()
	{
		return this.a;
	}

	// Token: 0x060027D4 RID: 10196 RVA: 0x000E6E88 File Offset: 0x000E5088
	public void a(int A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060027D5 RID: 10197 RVA: 0x000E6E94 File Offset: 0x000E5094
	public string b()
	{
		return this.b;
	}

	// Token: 0x060027D6 RID: 10198 RVA: 0x000E6E9C File Offset: 0x000E509C
	public void a(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x060027D7 RID: 10199 RVA: 0x000E6EA8 File Offset: 0x000E50A8
	public d9h()
	{
	}

	// Token: 0x060027D8 RID: 10200 RVA: 0x000E6EB4 File Offset: 0x000E50B4
	public bool jh(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && !string.IsNullOrWhiteSpace(this.b))
		{
			string name = string.Format("SpecialMerchandiseLevel_{0}", this.b);
			return serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(name, new int?(-1)).Value >= this.a;
		}
		return false;
	}

	// Token: 0x060027D9 RID: 10201 RVA: 0x000E6F20 File Offset: 0x000E5120
	public string ji()
	{
		return null;
	}

	// Token: 0x04001644 RID: 5700
	private int a;

	// Token: 0x04001645 RID: 5701
	private string b;
}
