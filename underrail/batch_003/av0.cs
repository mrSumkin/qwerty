using System;
using System.Runtime.Serialization;

// Token: 0x020001C4 RID: 452
[eiz("AMS")]
[Serializable]
public class av0 : d33, ISerializable
{
	// Token: 0x06000D5C RID: 3420 RVA: 0x00038E88 File Offset: 0x00037088
	protected av0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.b() != 0)
		{
			this.a = (esj)A_0.GetValue("AMS:BTHS", typeof(esj));
			this.b = A_0.GetInt32("AMS:HUV");
			return;
		}
		if (base.GetType() == typeof(av0))
		{
			this.a = (esj)A_0.GetValue("BaseTileHalfSize", typeof(esj));
			this.b = A_0.GetInt32("HeightUnitValue");
			return;
		}
		this.a = (esj)A_0.GetValue("AxonometricMaterializationSchema+BaseTileHalfSize", typeof(esj));
		this.b = A_0.GetInt32("AxonometricMaterializationSchema+HeightUnitValue");
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x00038F60 File Offset: 0x00037160
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AMS:BTHS", this.a);
		info.AddValue("AMS:HUV", this.b);
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x00038F94 File Offset: 0x00037194
	public av0()
	{
	}

	// Token: 0x040007E4 RID: 2020
	public new esj a;

	// Token: 0x040007E5 RID: 2021
	public new int b = 1;
}
