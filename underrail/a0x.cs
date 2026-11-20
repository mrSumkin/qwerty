using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000525 RID: 1317
[eiz("LE")]
[Serializable]
public abstract class a0x : c47, b2h, ISerializable
{
	// Token: 0x060021DE RID: 8670 RVA: 0x000B4720 File Offset: 0x000B2920
	protected a0x(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(a0x);
		}
	}

	// Token: 0x060021DF RID: 8671 RVA: 0x000B474C File Offset: 0x000B294C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x060021E0 RID: 8672 RVA: 0x000B4758 File Offset: 0x000B2958
	public bool a()
	{
		return false;
	}

	// Token: 0x060021E1 RID: 8673 RVA: 0x000B475C File Offset: 0x000B295C
	protected a0x()
	{
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x000B4768 File Offset: 0x000B2968
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Chat.ToString(),
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x000B47A4 File Offset: 0x000B29A4
	public virtual int? c()
	{
		return null;
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x000B47BC File Offset: 0x000B29BC
	public ecs se()
	{
		return new ecs(new List<dl6>
		{
			new dl6(new List<bph>
			{
				new bph(new d22(b94.a(), adi.h), this.hk(), null)
			})
		});
	}

	// Token: 0x060021E5 RID: 8677
	protected abstract string hk();
}
