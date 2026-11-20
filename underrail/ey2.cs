using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Common;

// Token: 0x02000546 RID: 1350
[eiz("PGXE")]
[Serializable]
public sealed class ey2 : aeq, b2h, ISerializable
{
	// Token: 0x0600228F RID: 8847 RVA: 0x000B6700 File Offset: 0x000B4900
	private ey2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetInt32("PGXE:A");
		this.b = A_0.GetBoolean("PGXE:LU");
		this.c = A_0.GetString("PGXE:R");
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x000B6748 File Offset: 0x000B4948
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PGXE:A", this.a);
		info.AddValue("PGXE:LU", this.b);
		info.AddValue("PGXE:R", this.c);
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x000B6790 File Offset: 0x000B4990
	public ey2(ap9 A_0, int A_1, bool A_2, string A_3 = null) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
		this.c = A_3;
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x000B67B0 File Offset: 0x000B49B0
	public bool a()
	{
		return false;
	}

	// Token: 0x06002293 RID: 8851 RVA: 0x000B67B8 File Offset: 0x000B49B8
	public List<string> b()
	{
		return new List<string>
		{
			TimelapseTextFeeds.Combat.ToString()
		};
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x000B67E0 File Offset: 0x000B49E0
	public ecs se()
	{
		ecs ecs = new ecs();
		dl6 dl = new dl6();
		ecs.a.Add(dl);
		if (this.c != null)
		{
			dl.a.Add(new bph(bvm.a(adi.p), string.Format("- Вы получаете {0} опыта за {1}.", this.a, this.c), null));
		}
		else
		{
			dl.a.Add(new bph(bvm.a(adi.p), string.Format("- Вы получаете {0} опыта.", this.a), null));
		}
		if (this.b)
		{
			dl6 dl2 = new dl6();
			ecs.a.Add(dl2);
			dl2.a.Add(new bph(bvm.a(adi.p), "- Вы набрали достаточно очков опыта, чтобы перейти на следующий уровень.", null));
		}
		return ecs;
	}

	// Token: 0x04001481 RID: 5249
	private int a;

	// Token: 0x04001482 RID: 5250
	private bool b;

	// Token: 0x04001483 RID: 5251
	private string c;
}
