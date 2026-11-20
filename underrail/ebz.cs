using System;
using System.Runtime.Serialization;

// Token: 0x02001928 RID: 6440
[elw(typeof(d48))]
[eiz("TI")]
[Serializable]
public class ebz : dj3, ISerializable
{
	// Token: 0x060088AF RID: 34991 RVA: 0x00388494 File Offset: 0x00386694
	protected ebz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060088B0 RID: 34992 RVA: 0x003884A0 File Offset: 0x003866A0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060088B1 RID: 34993 RVA: 0x003884AC File Offset: 0x003866AC
	public override string tv()
	{
		return "Инструмент";
	}

	// Token: 0x060088B2 RID: 34994 RVA: 0x003884B4 File Offset: 0x003866B4
	public ebz()
	{
	}

	// Token: 0x060088B3 RID: 34995 RVA: 0x003884BC File Offset: 0x003866BC
	public override bk3 tw()
	{
		ebz ebz = new ebz();
		this.ai7(ebz);
		return ebz;
	}
}
