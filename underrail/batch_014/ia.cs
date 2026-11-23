using System;
using System.Runtime.Serialization;

// Token: 0x0200144C RID: 5196
[eiz("SLIA")]
[Serializable]
public sealed class ia : b1z, ISerializable
{
	// Token: 0x060074CF RID: 29903 RVA: 0x00318934 File Offset: 0x00316B34
	private ia(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("SLIA:L", typeof(jy)) as jy);
		this.b = A_0.GetSingle("SLIA:V");
	}

	// Token: 0x060074D0 RID: 29904 RVA: 0x00318970 File Offset: 0x00316B70
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SLIA:L", this.a);
		info.AddValue("SLIA:V", this.b);
	}

	// Token: 0x060074D1 RID: 29905 RVA: 0x0031899C File Offset: 0x00316B9C
	public ia(ah7 A_0, float A_1)
	{
		this.a = new jy(A_0);
		this.b = A_1;
	}

	// Token: 0x060074D2 RID: 29906 RVA: 0x003189B8 File Offset: 0x00316BB8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (this.a == null || this.a.ao() == null)
		{
			return dc4.e;
		}
		this.a.ao().Light = new ae8(this.a.ao().Light.d(), this.b, this.a.ao().Light.a());
		this.a.ao().d();
		return dc4.c;
	}

	// Token: 0x04002FC3 RID: 12227
	private new jy a;

	// Token: 0x04002FC4 RID: 12228
	private float b;
}
