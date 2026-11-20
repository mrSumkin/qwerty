using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Locale;

// Token: 0x02001152 RID: 4434
[eiz("FZ0")]
[Serializable]
public sealed class esz : ISerializable
{
	// Token: 0x06005EF8 RID: 24312 RVA: 0x0028413C File Offset: 0x0028233C
	private esz(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetString("FZ0:F");
		this.b = (ZoneControlLevel)A_0.GetValue("FZ0:L", typeof(ZoneControlLevel));
	}

	// Token: 0x06005EF9 RID: 24313 RVA: 0x00284180 File Offset: 0x00282380
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("FZ0:F", this.a);
		info.AddValue("FZ0:L", this.b);
	}

	// Token: 0x170001CD RID: 461
	// (get) Token: 0x06005EFA RID: 24314 RVA: 0x002841AC File Offset: 0x002823AC
	// (set) Token: 0x06005EFB RID: 24315 RVA: 0x002841B4 File Offset: 0x002823B4
	public string FactionId
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

	// Token: 0x170001CE RID: 462
	// (get) Token: 0x06005EFC RID: 24316 RVA: 0x002841C0 File Offset: 0x002823C0
	// (set) Token: 0x06005EFD RID: 24317 RVA: 0x002841C8 File Offset: 0x002823C8
	public ZoneControlLevel ControlLevel
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

	// Token: 0x06005EFE RID: 24318 RVA: 0x002841D4 File Offset: 0x002823D4
	public esz()
	{
	}

	// Token: 0x06005EFF RID: 24319 RVA: 0x002841DC File Offset: 0x002823DC
	public esz(string A_0, ZoneControlLevel A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x040025CB RID: 9675
	private string a;

	// Token: 0x040025CC RID: 9676
	private ZoneControlLevel b;
}
