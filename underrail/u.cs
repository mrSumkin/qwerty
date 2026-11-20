using System;
using System.Runtime.Serialization;

// Token: 0x02000082 RID: 130
[eiz("IRE")]
[Serializable]
public abstract class u : ejt, dcm, ISerializable
{
	// Token: 0x06000302 RID: 770 RVA: 0x0000DC94 File Offset: 0x0000BE94
	protected u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000303 RID: 771 RVA: 0x0000DCA0 File Offset: 0x0000BEA0
	public bool Initialized
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x06000304 RID: 772 RVA: 0x0000DCA8 File Offset: 0x0000BEA8
	public bool bc(bool A_0)
	{
		if (this.a)
		{
			return false;
		}
		if (base.Carrier != null)
		{
			this.ih();
		}
		this.a = true;
		return true;
	}

	// Token: 0x06000305 RID: 773 RVA: 0x0000DCD0 File Offset: 0x0000BED0
	public bool bd(bool A_0)
	{
		if (!this.a)
		{
			return false;
		}
		this.ij();
		this.a = false;
		return true;
	}

	// Token: 0x06000306 RID: 774 RVA: 0x0000DCF0 File Offset: 0x0000BEF0
	public override void be(b0b A_0)
	{
		base.be(A_0);
		if (base.Carrier != null && base.Carrier.Initialized)
		{
			this.bc(true);
		}
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0000DD1C File Offset: 0x0000BF1C
	public u()
	{
	}

	// Token: 0x040003DB RID: 987
	[NonSerialized]
	private new bool a;
}
