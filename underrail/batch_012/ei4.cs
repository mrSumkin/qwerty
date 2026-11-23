using System;
using System.Runtime.Serialization;

// Token: 0x02001299 RID: 4761
[a(typeof(d8r))]
[eiz("HMREA")]
[Serializable]
public sealed class ei4 : d8r, ISerializable
{
	// Token: 0x060067FD RID: 26621 RVA: 0x002C0318 File Offset: 0x002BE518
	private ei4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("HMREA:B");
	}

	// Token: 0x060067FE RID: 26622 RVA: 0x002C0334 File Offset: 0x002BE534
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("HMREA:B", this.a);
	}

	// Token: 0x060067FF RID: 26623 RVA: 0x002C0350 File Offset: 0x002BE550
	public ei4(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006800 RID: 26624 RVA: 0x002C035C File Offset: 0x002BE55C
	public override void tt(int A_0, bool A_1)
	{
		if (!this.a && base.a8().o.b != null)
		{
			this.a = true;
			cd0 b = base.a8().o.b;
			b.a += "_Withered";
			base.a8().TileFormationModifiers.s4(1);
			base.a8().z();
			base.a8().IsGround = true;
			base.a8().ah();
		}
	}

	// Token: 0x04002AFA RID: 11002
	private bool a;
}
