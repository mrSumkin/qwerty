using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000AD3 RID: 2771
[eiz("XPBLPJJJ")]
[Serializable]
public sealed class c72 : cze
{
	// Token: 0x0600409E RID: 16542 RVA: 0x001898EC File Offset: 0x00187AEC
	private c72(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("XPBLPJJJ:JJI", typeof(Guid));
	}

	// Token: 0x0600409F RID: 16543 RVA: 0x00189924 File Offset: 0x00187B24
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XPBLPJJJ:JJI", this.a);
	}

	// Token: 0x060040A0 RID: 16544 RVA: 0x00189944 File Offset: 0x00187B44
	public Guid a()
	{
		return this.a;
	}

	// Token: 0x060040A1 RID: 16545 RVA: 0x0018994C File Offset: 0x00187B4C
	public void a(Guid A_0)
	{
		this.a = A_0;
	}

	// Token: 0x060040A2 RID: 16546 RVA: 0x00189958 File Offset: 0x00187B58
	public c72()
	{
	}

	// Token: 0x060040A3 RID: 16547 RVA: 0x00189970 File Offset: 0x00187B70
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		if (A_0 != null && A_0.Area != null)
		{
			c5x c5x = new ar7(this.a, A_0.Area).ao() as c5x;
			if (c5x != null)
			{
				wv wv = c5x.GetAspect<bim>() as wv;
				if (wv != null && wv.g() != null)
				{
					wv.g().l().Clear();
				}
				c5x.RemoveAspect<c3g>();
			}
		}
	}

	// Token: 0x04001C02 RID: 7170
	private new Guid a;

	// Token: 0x04001C03 RID: 7171
	private bt4 b = new bt4();
}
