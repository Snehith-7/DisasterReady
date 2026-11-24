// ==========================================================================
// DisasterReady - Calm & Mindful Interactive Systems
// ==========================================================================

document.addEventListener("DOMContentLoaded", function () {
    initEmergencyKitChecklist();
});

// --------------------------------------------------------------------------
// Interactive Emergency Go-Bag Checklist
// --------------------------------------------------------------------------
const STORAGE_KEY = "disaster_ready_kit_items";

function initEmergencyKitChecklist() {
    const kitBoxes = document.querySelectorAll(".kit-item-box");
    if (kitBoxes.length === 0) return;

    // Load saved checklist state
    let savedState = {};
    try {
        savedState = JSON.parse(localStorage.getItem(STORAGE_KEY)) || {};
    } catch (e) {
        savedState = {};
    }

    kitBoxes.forEach(box => {
        const itemId = box.getAttribute("data-item-id");
        if (savedState[itemId]) {
            box.classList.add("checked");
            const checkIcon = box.querySelector(".kit-check-icon");
            if (checkIcon) {
                checkIcon.className = "bi bi-check-circle-fill text-success fs-5 kit-check-icon";
            }
        }

        box.addEventListener("click", function () {
            this.classList.toggle("checked");
            const isChecked = this.classList.contains("checked");
            const icon = this.querySelector(".kit-check-icon");

            if (isChecked) {
                if (icon) icon.className = "bi bi-check-circle-fill text-success fs-5 kit-check-icon";
                savedState[itemId] = true;
            } else {
                if (icon) icon.className = "bi bi-circle text-secondary fs-5 kit-check-icon";
                delete savedState[itemId];
            }

            try {
                localStorage.setItem(STORAGE_KEY, JSON.stringify(savedState));
            } catch (e) { }

            updateKitProgress();
        });
    });

    updateKitProgress();

    // Reset button
    const resetBtn = document.getElementById("resetKitBtn");
    if (resetBtn) {
        resetBtn.addEventListener("click", function (e) {
            e.preventDefault();
            localStorage.removeItem(STORAGE_KEY);
            savedState = {};
            kitBoxes.forEach(box => {
                box.classList.remove("checked");
                const icon = box.querySelector(".kit-check-icon");
                if (icon) icon.className = "bi bi-circle text-secondary fs-5 kit-check-icon";
            });
            updateKitProgress();
        });
    }
}

function updateKitProgress() {
    const kitBoxes = document.querySelectorAll(".kit-item-box");
    const checkedBoxes = document.querySelectorAll(".kit-item-box.checked");
    const progressBar = document.getElementById("kitProgressBar");
    const countElem = document.getElementById("kitItemCount");
    const statusMsg = document.getElementById("kitStatusMessage");

    if (!progressBar || kitBoxes.length === 0) return;

    const total = kitBoxes.length;
    const packed = checkedBoxes.length;
    const pct = Math.round((packed / total) * 100);

    progressBar.style.width = `${pct}%`;
    if (countElem) {
        countElem.innerText = `${packed} of ${total} items (${pct}%)`;
    }

    if (statusMsg) {
        if (pct === 100) {
            statusMsg.className = "text-success fw-bold small";
            statusMsg.innerHTML = '<i class="bi bi-patch-check-fill me-1"></i> Excellent! Your Go-Bag is completely prepared.';
        } else if (pct >= 50) {
            statusMsg.className = "text-warning fw-semibold small";
            statusMsg.innerHTML = '<i class="bi bi-check2-circle me-1"></i> Great progress! Keep packing the remaining essential supplies.';
        } else {
            statusMsg.className = "text-secondary small";
            statusMsg.innerText = 'Click items to pack your essential 72-hour emergency go-bag.';
        }
    }
}


