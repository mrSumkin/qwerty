using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020006BE RID: 1726
public sealed class eoc : Stat<int>, xx
{
	// Token: 0x06002CAA RID: 11434 RVA: 0x000FF4B8 File Offset: 0x000FD6B8
	public efk re()
	{
		return this.a;
	}

	// Token: 0x06002CAB RID: 11435 RVA: 0x000FF4C0 File Offset: 0x000FD6C0
	public string a()
	{
		return this.b;
	}

	// Token: 0x06002CAC RID: 11436 RVA: 0x000FF4C8 File Offset: 0x000FD6C8
	public apq b()
	{
		return this.c;
	}

	// Token: 0x06002CAD RID: 11437 RVA: 0x000FF4D4 File Offset: 0x000FD6D4
	public override int? atw()
	{
		if (this.c != null)
		{
			return new int?(this.c.b());
		}
		return null;
	}

	// Token: 0x06002CAE RID: 11438 RVA: 0x000FF508 File Offset: 0x000FD708
	public eoc(efk A_0, string A_1)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = ac8.a(A_1);
		f f;
		this.a.Specializations.TryGetValue(this.b, out f);
		if (f != null)
		{
			base.a(f.Value);
		}
		base.a(this);
	}

	// Token: 0x06002CAF RID: 11439 RVA: 0x000FF568 File Offset: 0x000FD768
	protected override void lm(object A_0, c1 A_1)
	{
		base.lm(A_0, A_1);
		f f;
		this.a.Specializations.TryGetValue(this.b, out f);
		int num = (int)A_1.a();
		if (num == 0)
		{
			if (f != null)
			{
				this.a.Specializations.Remove(this.b);
				return;
			}
		}
		else
		{
			if (f == null)
			{
				f = new f();
				this.a.Specializations[this.b] = f;
			}
			f.Value = num;
		}
	}

	// Token: 0x04001964 RID: 6500
	private efk a;

	// Token: 0x04001965 RID: 6501
	private string b;

	// Token: 0x04001966 RID: 6502
	private apq c;
}
