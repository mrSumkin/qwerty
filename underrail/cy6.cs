using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x02001853 RID: 6227
[eiz("TSMA")]
[Serializable]
public class cy6 : bpr, cst, ISerializable
{
	// Token: 0x060084CA RID: 33994 RVA: 0x00373534 File Offset: 0x00371734
	protected cy6(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (m7)A_0.GetValue("TSMA:C", typeof(m7));
			return;
		}
		if (base.GetType() == typeof(cy6))
		{
			this.a = (m7)A_0.GetValue("_Categories", typeof(m7));
			return;
		}
		this.a = (m7)A_0.GetValue("TimelapseSimpleMoveAction+_Categories", typeof(m7));
	}

	// Token: 0x060084CB RID: 33995 RVA: 0x003735D0 File Offset: 0x003717D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("TSMA:C", this.a);
	}

	// Token: 0x060084CC RID: 33996 RVA: 0x003735F0 File Offset: 0x003717F0
	public m7 kh()
	{
		return this.a;
	}

	// Token: 0x060084CD RID: 33997 RVA: 0x003735F8 File Offset: 0x003717F8
	public cy6(mj A_0, Vector3 A_1, float? A_2, m7 A_3) : base(A_0, A_1, A_2, null)
	{
		this.a = A_3;
	}

	// Token: 0x040032E5 RID: 13029
	private new m7 a;
}
