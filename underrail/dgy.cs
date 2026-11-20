using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000C8E RID: 3214
[eiz("CW")]
[Serializable]
public abstract class dgy : ai, ISerializable, a5c
{
	// Token: 0x060048E3 RID: 18659 RVA: 0x001DB744 File Offset: 0x001D9944
	protected dgy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = (it)A_0.GetValue("CW:ECA", typeof(it));
			this.b = (bs0)A_0.GetValue("CW:WFDTEA", typeof(bs0));
			return;
		}
		if (base.GetType() == typeof(dgy))
		{
			this.a = (it)A_0.GetValue("_EndCutsceneActivity", typeof(it));
			this.b = (bs0)A_0.GetValue("_WaitForDialogToEndActivity", typeof(bs0));
			return;
		}
		this.a = (it)A_0.GetValue("CutsceneWorkflow+_EndCutsceneActivity", typeof(it));
		this.b = (bs0)A_0.GetValue("CutsceneWorkflow+_WaitForDialogToEndActivity", typeof(bs0));
	}

	// Token: 0x060048E4 RID: 18660 RVA: 0x001DB858 File Offset: 0x001D9A58
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CW:ECA", this.a);
		info.AddValue("CW:WFDTEA", this.b);
	}

	// Token: 0x060048E5 RID: 18661 RVA: 0x001DB884 File Offset: 0x001D9A84
	protected dgy()
	{
		base.ErrorHandling = d3s.c;
	}

	// Token: 0x060048E6 RID: 18662 RVA: 0x001DB8AC File Offset: 0x001D9AAC
	protected override bool b4(e6d A_0)
	{
		if (!base.f().Contains(this.a))
		{
			base.a(new btm[]
			{
				this.a
			});
		}
		if (!base.f().Contains(this.b))
		{
			base.a(0, new btm[]
			{
				this.b
			});
		}
		return base.b4(A_0);
	}

	// Token: 0x060048E7 RID: 18663 RVA: 0x001DB918 File Offset: 0x001D9B18
	public sealed override btm ev(Exception A_0, btm A_1)
	{
		b8q b8q = new b8q();
		if (!base.d().Contains(this.a))
		{
			b8q.a(new btm[]
			{
				new it()
			});
			List<btm> list = this.ti(A_0, A_1);
			if (list != null)
			{
				b8q.a(list.ToArray());
			}
		}
		return b8q;
	}

	// Token: 0x060048E8 RID: 18664 RVA: 0x001DB974 File Offset: 0x001D9B74
	protected virtual List<btm> ti(Exception A_0, btm A_1)
	{
		return new List<btm>();
	}

	// Token: 0x04001CC7 RID: 7367
	private new it a = new it();

	// Token: 0x04001CC8 RID: 7368
	private new bs0 b = new bs0();
}
