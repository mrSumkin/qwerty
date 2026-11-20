using System;
using System.Runtime.Serialization;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Rules.Combat;

// Token: 0x0200126D RID: 4717
[eiz("DWSEA2")]
[Serializable]
public sealed class ahw : Aspect<c5x>, c98
{
	// Token: 0x06006651 RID: 26193 RVA: 0x002B7F20 File Offset: 0x002B6120
	private ahw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06006652 RID: 26194 RVA: 0x002B7F2C File Offset: 0x002B612C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06006653 RID: 26195 RVA: 0x002B7F38 File Offset: 0x002B6138
	public ahw(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x06006654 RID: 26196 RVA: 0x002B7F44 File Offset: 0x002B6144
	public void r7(eds A_0)
	{
		bool flag = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Vehicle != null && serviceOrThrow.aqu().v().Vehicle.j()[DamageType.Mechanical].a() < 50)
		{
			flag = true;
		}
		if (this.a == null || this.a.Value != flag)
		{
			foreach (b0b b0b in base.a8().Area.Entities)
			{
				c5x c5x = (c5x)b0b;
				if (c5x.GetAspect<c9d>() != null)
				{
					if (flag)
					{
						c5x.TileFormationModifiers.s3(18);
					}
					else
					{
						c5x.TileFormationModifiers.s4(18);
					}
					c5x.z();
				}
			}
			this.a = new bool?(flag);
		}
	}

	// Token: 0x04002A7A RID: 10874
	private bool? a;
}
