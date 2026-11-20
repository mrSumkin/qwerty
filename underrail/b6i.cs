using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x020004AC RID: 1196
[eiz("CS49")]
[Serializable]
public sealed class b6i : ISerializable
{
	// Token: 0x06001E59 RID: 7769 RVA: 0x000A93B4 File Offset: 0x000A75B4
	private b6i(SerializationInfo A_0, StreamingContext A_1)
	{
		this.a = A_0.GetBoolean("CS49:L");
		this.b = A_0.GetBoolean("CS49:R");
		if (ell.a() >= 240)
		{
			di7.ReadDictionary<Hotkey, Keys>("CS49:B", ref this.d, A_0);
			this.a();
		}
		else
		{
			this.d = new Dictionary<Hotkey, Keys>();
			this.a();
		}
		if (ell.a() >= 321)
		{
			this.c = A_0.GetBoolean("CS49:ES");
			return;
		}
		this.c = true;
	}

	// Token: 0x06001E5A RID: 7770 RVA: 0x000A9470 File Offset: 0x000A7670
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		info.AddValue("CS49:L", this.a);
		info.AddValue("CS49:R", this.b);
		di7.WriteDictionary<Hotkey, Keys>("CS49:B", this.d, info);
		info.AddValue("CS49:ES", this.c);
	}

	// Token: 0x06001E5B RID: 7771 RVA: 0x000A94C4 File Offset: 0x000A76C4
	public bool b()
	{
		return this.a;
	}

	// Token: 0x06001E5C RID: 7772 RVA: 0x000A94CC File Offset: 0x000A76CC
	public void a(bool A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06001E5D RID: 7773 RVA: 0x000A94D8 File Offset: 0x000A76D8
	public bool f()
	{
		return this.b;
	}

	// Token: 0x06001E5E RID: 7774 RVA: 0x000A94E0 File Offset: 0x000A76E0
	public void c(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06001E5F RID: 7775 RVA: 0x000A94EC File Offset: 0x000A76EC
	public bool d()
	{
		return this.c;
	}

	// Token: 0x06001E60 RID: 7776 RVA: 0x000A94F4 File Offset: 0x000A76F4
	public void b(bool A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06001E61 RID: 7777 RVA: 0x000A9500 File Offset: 0x000A7700
	public Dictionary<Hotkey, Keys> c()
	{
		return this.d;
	}

	// Token: 0x06001E62 RID: 7778 RVA: 0x000A9508 File Offset: 0x000A7708
	public void a(Dictionary<Hotkey, Keys> A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06001E63 RID: 7779 RVA: 0x000A9514 File Offset: 0x000A7714
	public b6i()
	{
		this.a();
	}

	// Token: 0x06001E64 RID: 7780 RVA: 0x000A9544 File Offset: 0x000A7744
	public b6i e()
	{
		return new b6i
		{
			a = this.a,
			b = this.b,
			d = new Dictionary<Hotkey, Keys>(this.d),
			c = this.c
		};
	}

	// Token: 0x06001E65 RID: 7781 RVA: 0x000A9584 File Offset: 0x000A7784
	private void a()
	{
		this.a(Hotkey.HelpScreen, Keys.F1);
		this.a(Hotkey.QuickSave, Keys.F5);
		this.a(Hotkey.QuickLoad, Keys.F9);
		this.a(Hotkey.ActionButton1, Keys.D1);
		this.a(Hotkey.ActionButton2, Keys.D2);
		this.a(Hotkey.ActionButton3, Keys.D3);
		this.a(Hotkey.ActionButton4, Keys.D4);
		this.a(Hotkey.ActionButton5, Keys.D5);
		this.a(Hotkey.ActionButton6, Keys.D6);
		this.a(Hotkey.ActionButton7, Keys.D7);
		this.a(Hotkey.ActionButton8, Keys.D8);
		this.a(Hotkey.ActionButton9, Keys.D9);
		this.a(Hotkey.QuickButton1, Keys.Q);
		this.a(Hotkey.QuickButton2, Keys.W);
		this.a(Hotkey.QuickButton3, Keys.E);
		this.a(Hotkey.QuickButton4, Keys.R);
		this.a(Hotkey.QuickButton5, Keys.T);
		this.a(Hotkey.QuickButton6, Keys.Y);
		this.a(Hotkey.SwapWeapon, Keys.X);
		this.a(Hotkey.ReloadCurrentWeapon, Keys.OemCloseBrackets);
		this.a(Hotkey.ToggleShield, Keys.V);
		this.a(Hotkey.RechargeShield, Keys.B);
		this.a(Hotkey.EndTurn, Keys.Space);
		this.a(Hotkey.EndCombat, Keys.Enter);
		this.a(Hotkey.Highlight, Keys.Tab);
		this.a(Hotkey.ReverseHighlight, Keys.Z);
		this.a(Hotkey.TakeAll, Keys.A);
		this.a(Hotkey.QuickInvoker, Keys.F);
		this.a(Hotkey.CombatStatsOverview, Keys.C);
		this.a(Hotkey.CraftingWindow, Keys.G);
		this.a(Hotkey.CharacterSheet, Keys.S);
		this.a(Hotkey.Inventory, Keys.I);
		this.a(Hotkey.Notes, Keys.N);
		this.a(Hotkey.OdditiesWindow, Keys.O);
		this.a(Hotkey.VehicleWindow, Keys.H);
		this.a(Hotkey.GlobalMapWindow, Keys.M);
		this.a(Hotkey.Psi, Keys.P);
		this.a(Hotkey.ToggleHUD, Keys.F2);
		this.a(Hotkey.Escape, Keys.Escape);
		this.a(Hotkey.ScrollUp, Keys.Up);
		this.a(Hotkey.ScrollDown, Keys.Down);
		this.a(Hotkey.ScrollLeft, Keys.Left);
		this.a(Hotkey.ScrollRight, Keys.Right);
		this.a(Hotkey.SpeedUp, Keys.Add);
		this.a(Hotkey.SlowDown, Keys.Subtract);
		this.a(Hotkey.ToggleFollowPlayer, Keys.F3);
	}

	// Token: 0x06001E66 RID: 7782 RVA: 0x000A975C File Offset: 0x000A795C
	private void a(Hotkey A_0, Keys A_1)
	{
		if (!this.d.ContainsKey(A_0))
		{
			this.d[A_0] = A_1;
		}
	}

	// Token: 0x0400135F RID: 4959
	private bool a = true;

	// Token: 0x04001360 RID: 4960
	private bool b = true;

	// Token: 0x04001361 RID: 4961
	private bool c = true;

	// Token: 0x04001362 RID: 4962
	private Dictionary<Hotkey, Keys> d = new Dictionary<Hotkey, Keys>();
}
