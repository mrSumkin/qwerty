using System;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Common.Aspects;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020012AD RID: 4781
[eiz("SSEA99")]
[Serializable]
public sealed class dbh : Aspect<c5x>, ISerializable, bp1
{
	// Token: 0x060068E0 RID: 26848 RVA: 0x002C4FD4 File Offset: 0x002C31D4
	private dbh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("SSEA99:I");
	}

	// Token: 0x060068E1 RID: 26849 RVA: 0x002C4FF0 File Offset: 0x002C31F0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SSEA99:I", this.a);
	}

	// Token: 0x060068E2 RID: 26850 RVA: 0x002C500C File Offset: 0x002C320C
	public dbh(c5x A_0) : base(A_0)
	{
	}

	// Token: 0x060068E3 RID: 26851 RVA: 0x002C5018 File Offset: 0x002C3218
	public void mx()
	{
		if (!this.a)
		{
			amc aspect = base.a8().GetAspect<amc>();
			if (aspect != null)
			{
				aspect.ap = new CharacterState?(CharacterState.Custom1);
				aspect.aa().StatusEffects.a(new ewc(0), false, false, false);
				base.a8().Size = new Vector3(base.a8().Size.X, base.a8().Size.Y, 0.2f);
				base.a8().y = true;
			}
			this.a = true;
		}
	}

	// Token: 0x060068E4 RID: 26852 RVA: 0x002C50B4 File Offset: 0x002C32B4
	public void my()
	{
	}

	// Token: 0x04002B53 RID: 11091
	private bool a;
}
