using System;
using System.Runtime.Serialization;

// Token: 0x02001A00 RID: 6656
[eiz("EFX1")]
[Serializable]
public sealed class bro : d3e, ISerializable
{
	// Token: 0x06008FA1 RID: 36769 RVA: 0x003984A4 File Offset: 0x003966A4
	private bro(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008FA2 RID: 36770 RVA: 0x003984B0 File Offset: 0x003966B0
	public bro()
	{
	}

	// Token: 0x06008FA3 RID: 36771 RVA: 0x003984B8 File Offset: 0x003966B8
	public override string b2()
	{
		return "Ethereal";
	}

	// Token: 0x06008FA4 RID: 36772 RVA: 0x003984C4 File Offset: 0x003966C4
	public override d3e b3()
	{
		bro bro = new bro();
		this.xx(bro);
		return bro;
	}

	// Token: 0x06008FA5 RID: 36773 RVA: 0x003984E0 File Offset: 0x003966E0
	protected override void @in(ll A_0)
	{
		A_0.a().Ethereal = true;
	}
}
