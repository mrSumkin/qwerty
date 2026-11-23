using System;
using System.Runtime.Serialization;
using Ouroboros.Core.Logging;

// Token: 0x02001337 RID: 4919
[eiz("SBA1")]
[Serializable]
public sealed class ajj : dvv, ISerializable
{
	// Token: 0x06006F70 RID: 28528 RVA: 0x002EC6B8 File Offset: 0x002EA8B8
	private ajj(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (ar7)A_0.GetValue("SBA1:I", typeof(ar7));
		this.b = (ar7)A_0.GetValue("SBA1:M", typeof(ar7));
	}

	// Token: 0x06006F71 RID: 28529 RVA: 0x002EC710 File Offset: 0x002EA910
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SBA1:I", this.a);
		info.AddValue("SBA1:M", this.b);
	}

	// Token: 0x06006F72 RID: 28530 RVA: 0x002EC73C File Offset: 0x002EA93C
	public b0b b()
	{
		if (this.a == null)
		{
			return null;
		}
		return this.a.ao();
	}

	// Token: 0x06006F73 RID: 28531 RVA: 0x002EC758 File Offset: 0x002EA958
	public b0b a()
	{
		if (this.b == null)
		{
			return null;
		}
		return this.b.ao();
	}

	// Token: 0x06006F74 RID: 28532 RVA: 0x002EC774 File Offset: 0x002EA974
	public ajj(b0b A_0, b0b A_1)
	{
		this.a = new ar7(A_0);
		this.b = new ar7(A_1);
	}

	// Token: 0x06006F75 RID: 28533 RVA: 0x002EC798 File Offset: 0x002EA998
	protected override dc4 dt()
	{
		if (this.a() == null)
		{
			dux.b(LogSeverity.Error, "Unable to initialize StartBarteringAction. MerchantEntity was null.", new object[0]);
			return dc4.e;
		}
		if (this.b() != null)
		{
			aw1.b(this.b(), this.a(), false);
		}
		ps service = bpo.GetService<ps>();
		if (service != null)
		{
			service.amw(this.b(), this.a());
			return dc4.c;
		}
		return dc4.e;
	}

	// Token: 0x06006F76 RID: 28534 RVA: 0x002EC808 File Offset: 0x002EAA08
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		return dc4.e;
	}

	// Token: 0x04002D8F RID: 11663
	private new ar7 a;

	// Token: 0x04002D90 RID: 11664
	private ar7 b;
}
