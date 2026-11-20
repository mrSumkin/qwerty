using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x02001963 RID: 6499
[eiz("CSR")]
[Serializable]
public sealed class b8w : ISerializable
{
	// Token: 0x06008B00 RID: 35584 RVA: 0x0038E75C File Offset: 0x0038C95C
	private b8w(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetString("CSR:SN");
			this.b = A_0.GetSingle("CSR:F");
			return;
		}
		if (base.GetType() == typeof(b8w))
		{
			this.a = A_0.GetString("_SkillName");
			this.b = A_0.GetSingle("_Factor");
			return;
		}
		this.a = A_0.GetString("ComponentSkillRequirement+_SkillName");
		this.b = A_0.GetSingle("ComponentSkillRequirement+_Factor");
	}

	// Token: 0x06008B01 RID: 35585 RVA: 0x0038E7FC File Offset: 0x0038C9FC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CSR:SN", this.a);
		info.AddValue("CSR:F", this.b);
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06008B02 RID: 35586 RVA: 0x0038E820 File Offset: 0x0038CA20
	// (set) Token: 0x06008B03 RID: 35587 RVA: 0x0038E828 File Offset: 0x0038CA28
	[XmlAttribute]
	public string SkillName
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06008B04 RID: 35588 RVA: 0x0038E834 File Offset: 0x0038CA34
	// (set) Token: 0x06008B05 RID: 35589 RVA: 0x0038E83C File Offset: 0x0038CA3C
	[XmlAttribute]
	public float Factor
	{
		get
		{
			return this.b;
		}
		set
		{
			this.b = value;
		}
	}

	// Token: 0x06008B06 RID: 35590 RVA: 0x0038E848 File Offset: 0x0038CA48
	public b8w()
	{
	}

	// Token: 0x06008B07 RID: 35591 RVA: 0x0038E850 File Offset: 0x0038CA50
	public b8w(string A_0, float A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x04003789 RID: 14217
	private string a;

	// Token: 0x0400378A RID: 14218
	private float b;
}
