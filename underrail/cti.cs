using System;
using System.Runtime.Serialization;

// Token: 0x02001490 RID: 5264
[eiz("SRTA")]
[Serializable]
public sealed class cti : a6k, ISerializable
{
	// Token: 0x060076A2 RID: 30370 RVA: 0x003235D0 File Offset: 0x003217D0
	private cti(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(cti);
		}
	}

	// Token: 0x060076A3 RID: 30371 RVA: 0x003235FC File Offset: 0x003217FC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060076A4 RID: 30372 RVA: 0x00323608 File Offset: 0x00321808
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.e;
	}

	// Token: 0x060076A5 RID: 30373 RVA: 0x0032360C File Offset: 0x0032180C
	public cti()
	{
	}
}
