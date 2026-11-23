using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// Token: 0x02000078 RID: 120
[eiz("AB")]
[XmlRoot("AudioBank")]
[Serializable]
public sealed class eg9 : ISerializable
{
	// Token: 0x0600026F RID: 623 RVA: 0x0000C388 File Offset: 0x0000A588
	private eg9(SerializationInfo A_0, StreamingContext A_1)
	{
		if (ell.b() != 0)
		{
			di7.ReadList<za>("AB:S", ref this.a, A_0);
			di7.ReadList<dv5>("AB:SE", ref this.b, A_0);
			return;
		}
		if (base.GetType() == typeof(eg9))
		{
			this.a = (List<za>)A_0.GetValue("_Songs", typeof(List<za>));
			this.b = (List<dv5>)A_0.GetValue("_SoundEffects", typeof(List<dv5>));
			return;
		}
		this.a = (List<za>)A_0.GetValue("AudioBank+_Songs", typeof(List<za>));
		this.b = (List<dv5>)A_0.GetValue("AudioBank+_SoundEffects", typeof(List<dv5>));
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0000C47C File Offset: 0x0000A67C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		di7.WriteList<za>("AB:S", this.a, info);
		di7.WriteList<dv5>("AB:SE", this.b, info);
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0000C4A0 File Offset: 0x0000A6A0
	public List<za> a()
	{
		return this.a;
	}

	// Token: 0x06000272 RID: 626 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
	public void a(List<za> A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
	public List<dv5> b()
	{
		return this.b;
	}

	// Token: 0x06000274 RID: 628 RVA: 0x0000C4BC File Offset: 0x0000A6BC
	public void a(List<dv5> A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
	public eg9()
	{
	}

	// Token: 0x040003AD RID: 941
	private List<za> a = new List<za>();

	// Token: 0x040003AE RID: 942
	private List<dv5> b = new List<dv5>();
}
