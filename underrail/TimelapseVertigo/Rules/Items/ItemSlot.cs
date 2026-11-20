using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;

namespace TimelapseVertigo.Rules.Items
{
	// Token: 0x0200222E RID: 8750
	[eiz("IS")]
	[Serializable]
	public class ItemSlot<T> : c1e, IItemSlot<T>, ISerializable where T : coh
	{
		// Token: 0x0600CB03 RID: 51971 RVA: 0x0047DDB4 File Offset: 0x0047BFB4
		protected ItemSlot(SerializationInfo A_0, StreamingContext A_1)
		{
			if (ell.a() != 0)
			{
				this.a = (T)((object)A_0.GetValue("IS:I", typeof(T)));
				this.b = A_0.GetBoolean("IS:E");
				if (ell.a() >= 4)
				{
					di7.ReadEvent<c1>("IS:IC", ref this.c, A_0);
					return;
				}
			}
			else
			{
				if (base.GetType() == typeof(ItemSlot<T>))
				{
					this.a = (T)((object)A_0.GetValue("_Item", typeof(T)));
					this.b = A_0.GetBoolean("_Enabled");
					return;
				}
				this.a = (T)((object)A_0.GetValue("ItemSlot`1+_Item", typeof(T)));
				this.b = A_0.GetBoolean("ItemSlot`1+_Enabled");
			}
		}

		// Token: 0x0600CB04 RID: 51972 RVA: 0x0047DEA4 File Offset: 0x0047C0A4
		public void TransferEvent<R>(ItemSlot<R> newSlot) where R : coh
		{
			newSlot.c = this.c;
		}

		// Token: 0x0600CB05 RID: 51973 RVA: 0x0047DEB4 File Offset: 0x0047C0B4
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("IS:I", this.a);
			info.AddValue("IS:E", this.b);
			di7.WriteEvent<c1>("IS:IC", this.c, info);
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600CB06 RID: 51974 RVA: 0x0047DEF0 File Offset: 0x0047C0F0
		// (set) Token: 0x0600CB07 RID: 51975 RVA: 0x0047DEF8 File Offset: 0x0047C0F8
		public T Item
		{
			get
			{
				return this.a;
			}
			set
			{
				if (value != this.a)
				{
					this.b(value);
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600CB08 RID: 51976 RVA: 0x0047DF18 File Offset: 0x0047C118
		// (set) Token: 0x0600CB09 RID: 51977 RVA: 0x0047DF20 File Offset: 0x0047C120
		public bool Enabled
		{
			get
			{
				return this.b;
			}
			set
			{
				this.b = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600CB0A RID: 51978 RVA: 0x0047DF2C File Offset: 0x0047C12C
		public Type ItemType
		{
			get
			{
				return typeof(T);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600CB0B RID: 51979 RVA: 0x0047DF38 File Offset: 0x0047C138
		// (set) Token: 0x0600CB0C RID: 51980 RVA: 0x0047DF48 File Offset: 0x0047C148
		public coh Value
		{
			get
			{
				return this.a;
			}
			set
			{
				this.a = (value as T);
			}
		}

		// Token: 0x0600CB0D RID: 51981 RVA: 0x0047DF5C File Offset: 0x0047C15C
		[CompilerGenerated]
		public void pm(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.c;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Combine(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.c, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600CB0E RID: 51982 RVA: 0x0047DF94 File Offset: 0x0047C194
		[CompilerGenerated]
		public void pn(EventHandler<c1> A_0)
		{
			EventHandler<c1> eventHandler = this.c;
			EventHandler<c1> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<c1> value = (EventHandler<c1>)Delegate.Remove(eventHandler2, A_0);
				eventHandler = Interlocked.CompareExchange<EventHandler<c1>>(ref this.c, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600CB0F RID: 51983 RVA: 0x0047DFCC File Offset: 0x0047C1CC
		public ItemSlot()
		{
		}

		// Token: 0x0600CB10 RID: 51984 RVA: 0x0047DFDC File Offset: 0x0047C1DC
		public bool a(T A_0, bool A_1)
		{
			if (A_1 || this.c(A_0))
			{
				object a_ = this.a;
				this.a = A_0;
				if (this.c != null)
				{
					this.c(this, new c1(a_, this.a));
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600CB11 RID: 51985 RVA: 0x0047E03C File Offset: 0x0047C23C
		public bool b(T A_0)
		{
			return this.a(A_0, false);
		}

		// Token: 0x0600CB12 RID: 51986 RVA: 0x0047E048 File Offset: 0x0047C248
		public virtual bool c(T A_0)
		{
			return true;
		}

		// Token: 0x0600CB13 RID: 51987 RVA: 0x0047E04C File Offset: 0x0047C24C
		public void po(coh A_0)
		{
			this.a(A_0 as T, true);
		}

		// Token: 0x0600CB14 RID: 51988 RVA: 0x0047E064 File Offset: 0x0047C264
		public T pp()
		{
			return this.a;
		}

		// Token: 0x04004B10 RID: 19216
		internal T a;

		// Token: 0x04004B11 RID: 19217
		internal bool b = true;

		// Token: 0x04004B12 RID: 19218
		[CompilerGenerated]
		private EventHandler<c1> c;
	}
}
