using System;
using System.Runtime.Serialization;

// Token: 0x02001179 RID: 4473
[eiz("CSN")]
[Serializable]
public sealed class t : ISerializable
{
	// Token: 0x06005F9B RID: 24475 RVA: 0x0029ACB0 File Offset: 0x00298EB0
	private t(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = (A_0.GetValue("CSN:DS", typeof(b53)) as b53);
	}

	// Token: 0x06005F9C RID: 24476 RVA: 0x0029ACE4 File Offset: 0x00298EE4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		info.AddValue("CSN:DS", this.a);
	}

	// Token: 0x06005F9D RID: 24477 RVA: 0x0029ACF8 File Offset: 0x00298EF8
	public b53 a()
	{
		return this.a;
	}

	// Token: 0x06005F9E RID: 24478 RVA: 0x0029AD00 File Offset: 0x00298F00
	public void a(b53 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005F9F RID: 24479 RVA: 0x0029AD0C File Offset: 0x00298F0C
	public t()
	{
	}

	// Token: 0x06005FA0 RID: 24480 RVA: 0x0029AD20 File Offset: 0x00298F20
	public t b()
	{
		return new t
		{
			a = ((this.a != null) ? this.a.a() : null)
		};
	}

	// Token: 0x040027FE RID: 10238
	private b53 a = new b53();
}
